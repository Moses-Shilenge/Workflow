using BusinessLogic.Custom_Activities;
using BusinessObject.DtoModels;
using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class PopupForm : Form
    {
        Game _game = new Game();

        public PopupForm(Game game)
        {
            InitializeComponent();
            _game = game;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            Dictionary<string, object> updateGame = new Dictionary<string, object>();

            var game = _game;
            game.Guess = Int32.Parse(textBox1.Text);

            updateGame.Add("Game", game);

            var display = (Game)WorkflowInvoker.Invoke(update, updateGame);

            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            label2.Text = string.Format("Lets see how well you did: \r\nGuess = {0}\r\n MaxNumber = {1}\r\nResult = {2}\r\nTurns = {3}\r\nWorkflowType = {4}", _game.Guess, _game.MaxNumber, _game.Result, _game.Turns, _game.WorkflowType);
        }
    }
}
