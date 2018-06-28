using BusinessLogic.Main_Workflows;
using BusinessObject.DtoModels;
using System;
using System.Activities;
using System.Activities.DurableInstancing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.DurableInstancing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class WorkFlowApplication : IWorkFlowApplication
    {
        const string databaseConnection = "Data Source=MOSESS\\MOSESS;initial catalog=Workflow;integrated security=True;App=EntityFramework";

        public void InvokeWorkFlow()
        {
            SqlWorkflowInstanceStore store = new SqlWorkflowInstanceStore(databaseConnection);
            WorkflowApplication.CreateDefaultInstanceOwner(store, null, WorkflowIdentityFilter.Any);
        }

        public void ResumeWorkFlow(BusinessObject.DtoModels.Game game)
        {
            Exception exception = new Exception();

            Guid workflowInstanceID = game.InstanceId;

            SqlWorkflowInstanceStore store = new SqlWorkflowInstanceStore(databaseConnection);            
            store.InstanceLockedExceptionAction = InstanceLockedExceptionAction.BasicRetry;
            store.HostLockRenewalPeriod = TimeSpan.FromSeconds(2);


            InstanceHandle instanceHandle = store.CreateInstanceHandle();
            CreateWorkflowOwnerCommand createOwnerCmd = new CreateWorkflowOwnerCommand();
            InstanceView view = store.Execute(instanceHandle, createOwnerCmd, TimeSpan.FromSeconds(10));
            store.DefaultInstanceOwner = view.InstanceOwner;

            WorkflowApplicationInstance instance = WorkflowApplication.GetInstance(workflowInstanceID, store);

            AutoResetEvent syncEvent = new AutoResetEvent(false);

            WorkflowApplication wfApplication = new WorkflowApplication(new FlowchartNumberGuessWorkflow(), instance.DefinitionIdentity);

            wfApplication.PersistableIdle = (e) => PersistableIdleAction.Unload;
            wfApplication.Unloaded = (e) => { syncEvent.Set(); };
            wfApplication.OnUnhandledException = (e) =>
            {
                exception = e.UnhandledException;
                syncEvent.Set();
                return UnhandledExceptionAction.Cancel;

            };

            wfApplication.Load(instance);

            BookmarkResumptionResult result = wfApplication.ResumeBookmark("Decision", game);

            syncEvent.WaitOne();

            if (exception.Message != string.Empty && exception.StackTrace != null)
            {
                throw exception;
            }

            DeleteWorkflowOwnerCommand deleteOwnerCmd = new DeleteWorkflowOwnerCommand();
            store.Execute(instanceHandle, deleteOwnerCmd, TimeSpan.FromSeconds(10));
        }

        public List<InstancesTable> PersistedWorkFlowInstances()
        {
            IGameService gameService = new GameService();

            return gameService.GetInstances();
        }

        public WorkflowApplicationInstance GetInstance(Guid workflowInstanceID)
        {
            SqlWorkflowInstanceStore store = new SqlWorkflowInstanceStore(databaseConnection);
            store.InstanceLockedExceptionAction = InstanceLockedExceptionAction.BasicRetry;
            store.HostLockRenewalPeriod = TimeSpan.FromSeconds(2);


            InstanceHandle instanceHandle = store.CreateInstanceHandle();
            CreateWorkflowOwnerCommand createOwnerCmd = new CreateWorkflowOwnerCommand();
            InstanceView view = store.Execute(instanceHandle, createOwnerCmd, TimeSpan.FromSeconds(10));
            store.DefaultInstanceOwner = view.InstanceOwner;

            return WorkflowApplication.GetInstance(workflowInstanceID, store);
        }

        public string GetIdentityDescription(WorkflowIdentity workflowIdentity)
        {
            return WorkflowVersionMap.GetIdentityDescription(workflowIdentity);
        }



        public Activity GetWorkflowDefinition(WorkflowIdentity workflowIdentity)
        {
            return WorkflowVersionMap.GetWorkflowDefinition(workflowIdentity);
        }

        // Configure the instance store and workflow cycle handlers
        public Dictionary<string, object> ConfigureWorkflowApplication(WorkflowApplication wfApp)
        {
            // Configure the persistence store.
            SqlWorkflowInstanceStore store = new SqlWorkflowInstanceStore(databaseConnection);

            wfApp.InstanceStore = store;

            // Created for updating the user of events happening
            Dictionary<string, object> actionAndMessage = new Dictionary<string, object>();

            // Add a StringWriter to the extensions. This captures the output
            // from the WriteLine activities so we can display it in the form.
            StringWriter sw = new StringWriter();

            wfApp.Extensions.Add(sw);

            wfApp.Completed = delegate(WorkflowApplicationCompletedEventArgs e)
            {
            };

            wfApp.Aborted = delegate(WorkflowApplicationAbortedEventArgs e)
            {
            };

            wfApp.OnUnhandledException = delegate(WorkflowApplicationUnhandledExceptionEventArgs e)
            {
                return UnhandledExceptionAction.Terminate;
            };

            wfApp.PersistableIdle = delegate(WorkflowApplicationIdleEventArgs e)
            {
                return PersistableIdleAction.Unload;
            };

            // Start the workflow.
            wfApp.Run();

            return actionAndMessage;
        }
    }
}
