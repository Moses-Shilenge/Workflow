using BusinessLogic.Custom_Activities;
using BusinessLogic.Services;
using BusinessObject.DtoModels;
using System;
using System.Activities;
using System.Activities.DurableInstancing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class GuessTheNumberGame : Form
    {
        private IWorkFlowApplication _workflowApplication;
        private IGameService _gameService;

        public GuessTheNumberGame()
        {
            InitializeComponent();

            _workflowApplication = new WorkFlowApplication();
            _gameService = new GameService();
        }

        const string connectionString = "Data Source=MOSESS\\MOSESS;initial catalog=Workflow;integrated security=True;App=EntityFramework";
        SqlWorkflowInstanceStore store;
        bool WorkflowStarting;
        Guid GameId;

        public Guid WorkflowInstanceId
        {
            get
            {
                return InstanceId.SelectedIndex == -1 ? Guid.Empty : (Guid)InstanceId.SelectedItem;
            }
        }

        // Load the window and read the instance Id's stored oin the DB to populate on the dropdown to resume a workflow
        private void GuessTheNumberGame_Load(object sender, EventArgs e)
        {
            // Initialize the store and configure it so that it can be used for
            // multiple WorkflowApplication instances.
            _workflowApplication.InvokeWorkFlow();

            // Populate drop down list with the instance Ids
            _gameService.GetInstances().ForEach(
                i => InstanceId.Items.Add(i.Id)
             );

            // Set default ComboBox selections.
            NumberRange.SelectedIndex = 0;
            WorkflowType.SelectedIndex = 0;
        }

        private void InstanceId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InstanceId.SelectedIndex == -1)
            {
                return;
            }

            // Clear the status window.
            WorkflowStatus.Clear();
            
            // Get the workflow version and display it.
            // If the workflow is just starting then this info will not
            // be available in the persistence store so do not try and retrieve it.
            if (!WorkflowStarting)
            {
                var instance = _workflowApplication.GetInstance(this.WorkflowInstanceId);
                WorkflowVersion.Text = WorkflowVersionMap.GetIdentityDescription(instance.DefinitionIdentity);
                
                // Unload the instance.
                instance.Abandon();
            }
        }

        private delegate void UpdateStatusDelegate(string msg);

        public void UpdateStatus(string msg)
        {
            // We may be on a different thread so we need to
            // make this call using BeginInvoke.
            if (InvokeRequired)
            {
                BeginInvoke(new UpdateStatusDelegate(UpdateStatus), msg);
            }
            else
            {
                if (!msg.EndsWith("\r\n"))
                {
                    msg += "\r\n";
                }
                WorkflowStatus.AppendText(msg);
                WorkflowStatus.SelectionStart = WorkflowStatus.Text.Length;
                WorkflowStatus.ScrollToCaret();
            }
        }

        private delegate void GameOverDelegate();

        private void GameOver()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new GameOverDelegate(GameOver));
            }
            else
            {
                // Remove this instance from the combo box
                InstanceId.Items.Remove(InstanceId.SelectedItem);
                InstanceId.SelectedIndex = -1;
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            var inputs = new Dictionary<string, object>();
            inputs.Add("MaxNumber", Convert.ToInt32(NumberRange.SelectedItem));

            WorkflowIdentity identity = null;

            switch (WorkflowType.SelectedItem.ToString())
            {
                case "SequentialNumberGuessWorkflow":
                    identity = WorkflowVersionMap.SequentialNumberGuessIdentity;
                    break;
                case "StateMachineNumberGuessWorkflow":
                    identity = WorkflowVersionMap.StateMachineNumberGuessIdentity;
                    break;
                case "FlowchartNumberGuessWorkflow":
                    identity = WorkflowVersionMap.FlowchartNumberGuessIdentity;
                    break;
            };

            Activity wf = WorkflowVersionMap.GetWorkflowDefinition(identity);

            WorkflowApplication wfApp = new WorkflowApplication(wf, inputs, identity);

            // Add the workflow to the list and display the version information.
            WorkflowStarting = true;
            InstanceId.SelectedIndex = InstanceId.Items.Add(wfApp.Id);
            WorkflowVersion.Text = identity.ToString();
            WorkflowStarting = false;

            // Updates the status with the events results
            // Configure the instance store, extensions, and
            // workflow lifecycle handlers.
            _workflowApplication.ConfigureWorkflowApplication(wfApp);
        }

        private void EnterGuess_Click(object sender, EventArgs e)
        {
            if (WorkflowInstanceId == Guid.Empty)
            {
                MessageBox.Show("Please select a workflow.");
                return;
            }
            int guess;

            if (!Int32.TryParse(Guess.Text, out guess))
            {
                MessageBox.Show("Please enter an integer.");
                Guess.SelectAll();
                Guess.Focus();
                return;
            }

            var instance = _workflowApplication.GetInstance(this.WorkflowInstanceId);


            // Use the persisted WorkflowIdentity to retrieve the correct workflow
            // definition from the dictionary.
            Activity wf = WorkflowVersionMap.GetWorkflowDefinition(instance.DefinitionIdentity);

            // Associate the WorkflowApplication with the correct definition
            WorkflowApplication wfApp = new WorkflowApplication(wf, instance.DefinitionIdentity);

            // Configure the extensions and lifecycle handlers.
            // Do this before the instance is loaded. Once the instance is
            // loaded it is too late to add extensions.

            // Configure the instance store, extensions, and
            // workflow lifecycle handlers.
            var events = _workflowApplication.ConfigureWorkflowApplication(wfApp);

            // Load the workflow.
            //wfApp.Load(instance);

            // Create game Id
            GameId = Guid.NewGuid();

            var game = new Game() { Id = GameId, InstanceId = WorkflowInstanceId, Guess = guess, WorkflowType = WorkflowType.SelectedItem.ToString(), MaxNumber = Convert.ToInt32(NumberRange.SelectedItem) };

            // Resume the workflow.
            wfApp.ResumeBookmark("Game", game);

            // Clear the Guess textbox.
            Guess.Clear();
            Guess.Focus();

            Game display = null;

            while (display == null)
            {
                display = RetrieveData();
            }

            UpdateStatus(string.Format("Lets see how well you did: \r\n\r\nGuess = {0}\r\n MaxNumber = {1}\r\nResult = {2}\r\nTurns = {3}\r\nWorkflowType = {4}", display.Guess, display.MaxNumber, display.Result, display.Turns, display.WorkflowType));

        }

        private Game RetrieveData()
        {
            // Get the game
            Retrieve retrieve = new Retrieve();
            Dictionary<string, object> getGame = new Dictionary<string, object>();
            getGame.Add("GameID", GameId.ToString());

            return (Game)WorkflowInvoker.Invoke(retrieve, getGame);
        }

        private void QuitGame_Click(object sender, EventArgs e)
        {
            if (WorkflowInstanceId == Guid.Empty)
            {
                MessageBox.Show("Please select a workflow.");
                return;
            }

            var instance = _workflowApplication.GetInstance(this.WorkflowInstanceId);

            // Use the persisted WorkflowIdentity to retrieve the correct workflow
            // definition from the dictionary.
            Activity wf = WorkflowVersionMap.GetWorkflowDefinition(instance.DefinitionIdentity);

            // Associate the WorkflowApplication with the correct definition
            WorkflowApplication wfApp = new WorkflowApplication(wf, instance.DefinitionIdentity);
            
            _workflowApplication.ConfigureWorkflowApplication(wfApp);

            // Load the workflow.
            wfApp.Load(instance);

            // Terminate the workflow.
            wfApp.Terminate("User resigns.");
        }

        private void Update_Click(object sender, EventArgs e)
        {
            PopupForm popup = new PopupForm(RetrieveData());
            popup.ShowDialog();

            Game display = null;

            if (popup.IsDisposed)
            {
                display = RetrieveData();
            }

            UpdateStatus(string.Format("\r\n\r\nUpdate happened: \r\n\r\nGuess = {0}\r\n MaxNumber = {1}\r\nResult = {2}\r\nTurns = {3}\r\nWorkflowType = {4}", display.Guess, display.MaxNumber, display.Result, display.Turns, display.WorkflowType));
        }
    }
}
