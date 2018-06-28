namespace Frontend
{
    partial class GuessTheNumberGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.NumberRange = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WorkflowStatus = new System.Windows.Forms.TextBox();
            this.QuitGame = new System.Windows.Forms.Button();
            this.EnterGuess = new System.Windows.Forms.Button();
            this.Guess = new System.Windows.Forms.TextBox();
            this.InstanceId = new System.Windows.Forms.ComboBox();
            this.WorkflowVersion = new System.Windows.Forms.Label();
            this.WorkflowType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Workflow Type";
            // 
            // NumberRange
            // 
            this.NumberRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberRange.FormattingEnabled = true;
            this.NumberRange.Items.AddRange(new object[] {
            "10",
            "100",
            "1000"});
            this.NumberRange.Location = new System.Drawing.Point(227, 9);
            this.NumberRange.Name = "NumberRange";
            this.NumberRange.Size = new System.Drawing.Size(143, 21);
            this.NumberRange.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Guess a number from 1 to";
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(12, 10);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 21;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Guess";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Workflow Instance Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.WorkflowStatus);
            this.groupBox1.Controls.Add(this.QuitGame);
            this.groupBox1.Controls.Add(this.EnterGuess);
            this.groupBox1.Controls.Add(this.Guess);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.InstanceId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 287);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(6, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Update_Click);
            // 
            // WorkflowStatus
            // 
            this.WorkflowStatus.Location = new System.Drawing.Point(6, 68);
            this.WorkflowStatus.Multiline = true;
            this.WorkflowStatus.Name = "WorkflowStatus";
            this.WorkflowStatus.ReadOnly = true;
            this.WorkflowStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WorkflowStatus.Size = new System.Drawing.Size(338, 176);
            this.WorkflowStatus.TabIndex = 6;
            // 
            // QuitGame
            // 
            this.QuitGame.Location = new System.Drawing.Point(270, 37);
            this.QuitGame.Name = "QuitGame";
            this.QuitGame.Size = new System.Drawing.Size(75, 23);
            this.QuitGame.TabIndex = 5;
            this.QuitGame.Text = "Quit";
            this.QuitGame.UseVisualStyleBackColor = true;
            this.QuitGame.Click += new System.EventHandler(this.QuitGame_Click);
            // 
            // EnterGuess
            // 
            this.EnterGuess.Location = new System.Drawing.Point(117, 37);
            this.EnterGuess.Name = "EnterGuess";
            this.EnterGuess.Size = new System.Drawing.Size(75, 23);
            this.EnterGuess.TabIndex = 4;
            this.EnterGuess.Text = "Enter Guess";
            this.EnterGuess.UseVisualStyleBackColor = true;
            this.EnterGuess.Click += new System.EventHandler(this.EnterGuess_Click);
            // 
            // Guess
            // 
            this.Guess.Location = new System.Drawing.Point(46, 39);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(65, 20);
            this.Guess.TabIndex = 3;
            // 
            // InstanceId
            // 
            this.InstanceId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstanceId.FormattingEnabled = true;
            this.InstanceId.Location = new System.Drawing.Point(117, 12);
            this.InstanceId.Name = "InstanceId";
            this.InstanceId.Size = new System.Drawing.Size(227, 21);
            this.InstanceId.TabIndex = 1;
            this.InstanceId.SelectedIndexChanged += new System.EventHandler(this.InstanceId_SelectedIndexChanged);
            // 
            // WorkflowVersion
            // 
            this.WorkflowVersion.AutoSize = true;
            this.WorkflowVersion.Location = new System.Drawing.Point(12, 359);
            this.WorkflowVersion.Name = "WorkflowVersion";
            this.WorkflowVersion.Size = new System.Drawing.Size(90, 13);
            this.WorkflowVersion.TabIndex = 26;
            this.WorkflowVersion.Text = "Workflow Version";
            // 
            // WorkflowType
            // 
            this.WorkflowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkflowType.FormattingEnabled = true;
            this.WorkflowType.Items.AddRange(new object[] {
            "StateMachineNumberGuessWorkflow",
            "FlowchartNumberGuessWorkflow",
            "SequentialNumberGuessWorkflow"});
            this.WorkflowType.Location = new System.Drawing.Point(93, 37);
            this.WorkflowType.Name = "WorkflowType";
            this.WorkflowType.Size = new System.Drawing.Size(277, 21);
            this.WorkflowType.TabIndex = 25;
            // 
            // GuessTheNumberGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberRange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WorkflowVersion);
            this.Controls.Add(this.WorkflowType);
            this.Name = "GuessTheNumberGame";
            this.Text = "GuessTheNumberGame";
            this.Load += new System.EventHandler(this.GuessTheNumberGame_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NumberRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WorkflowStatus;
        private System.Windows.Forms.Button QuitGame;
        private System.Windows.Forms.Button EnterGuess;
        private System.Windows.Forms.TextBox Guess;
        private System.Windows.Forms.ComboBox InstanceId;
        private System.Windows.Forms.Label WorkflowVersion;
        private System.Windows.Forms.ComboBox WorkflowType;


    }
}