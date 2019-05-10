namespace SNake
{
    partial class SnakeGame
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
            this.MenuLabel = new System.Windows.Forms.Label();
            this.HeadBox = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Namebox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.SpecFoodBox = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.SpeedBox = new System.Windows.Forms.ComboBox();
            this.BackgroundBox = new System.Windows.Forms.ComboBox();
            this.Leaderboard = new System.Windows.Forms.DataGridView();
            this.NumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Leaderboard)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLabel
            // 
            this.MenuLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuLabel.Location = new System.Drawing.Point(0, 0);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(398, 392);
            this.MenuLabel.TabIndex = 0;
            this.MenuLabel.Text = "Snake\r\n\r\nUse the arrow keys to change directions. Use the space bar to pause. \r\n\r" +
    "\nPress Start to begin.";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HeadBox
            // 
            this.HeadBox.BackColor = System.Drawing.SystemColors.Window;
            this.HeadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeadBox.FormattingEnabled = true;
            this.HeadBox.Items.AddRange(new object[] {
            "Black",
            "Yellow",
            "Red"});
            this.HeadBox.Location = new System.Drawing.Point(35, 177);
            this.HeadBox.Name = "HeadBox";
            this.HeadBox.Size = new System.Drawing.Size(121, 24);
            this.HeadBox.TabIndex = 4;
            this.HeadBox.SelectedIndexChanged += new System.EventHandler(this.HeadBox_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(32, 159);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 18);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Snake head Color:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(35, 363);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Namebox
            // 
            this.Namebox.Location = new System.Drawing.Point(292, 322);
            this.Namebox.Name = "Namebox";
            this.Namebox.Size = new System.Drawing.Size(100, 22);
            this.Namebox.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(289, 304);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 18);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Player Name:";
            // 
            // SpecFoodBox
            // 
            this.SpecFoodBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Pink",
            "Aqua",
            "Grey"});
            this.SpecFoodBox.BackColor = System.Drawing.SystemColors.Window;
            this.SpecFoodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecFoodBox.FormattingEnabled = true;
            this.SpecFoodBox.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold"});
            this.SpecFoodBox.Location = new System.Drawing.Point(35, 222);
            this.SpecFoodBox.Name = "SpecFoodBox";
            this.SpecFoodBox.Size = new System.Drawing.Size(121, 24);
            this.SpecFoodBox.TabIndex = 7;
            this.SpecFoodBox.SelectedIndexChanged += new System.EventHandler(this.SpecFoodBox_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(32, 204);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(135, 18);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Special food Color:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(226, 159);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(133, 18);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Background Color:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(226, 204);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(98, 18);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Snake speed:";
            // 
            // SpeedBox
            // 
            this.SpeedBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Pink",
            "Aqua",
            "Grey"});
            this.SpeedBox.BackColor = System.Drawing.SystemColors.Window;
            this.SpeedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeedBox.FormattingEnabled = true;
            this.SpeedBox.Items.AddRange(new object[] {
            "Slow",
            "Medium",
            "Fast"});
            this.SpeedBox.Location = new System.Drawing.Point(229, 221);
            this.SpeedBox.Name = "SpeedBox";
            this.SpeedBox.Size = new System.Drawing.Size(121, 24);
            this.SpeedBox.TabIndex = 11;
            this.SpeedBox.SelectedIndexChanged += new System.EventHandler(this.SpeedBox_SelectedIndexChanged);
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Pink",
            "Aqua",
            "Grey"});
            this.BackgroundBox.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackgroundBox.FormattingEnabled = true;
            this.BackgroundBox.Items.AddRange(new object[] {
            "White",
            "Grey",
            "Light blue"});
            this.BackgroundBox.Location = new System.Drawing.Point(229, 177);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(121, 24);
            this.BackgroundBox.TabIndex = 12;
            this.BackgroundBox.SelectedIndexChanged += new System.EventHandler(this.BackgroundBox_SelectedIndexChanged);
            // 
            // Leaderboard
            // 
            this.Leaderboard.AllowUserToAddRows = false;
            this.Leaderboard.AllowUserToDeleteRows = false;
            this.Leaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Leaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberColumn,
            this.Player_Name,
            this.ScoreColumn});
            this.Leaderboard.Location = new System.Drawing.Point(35, 248);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.ReadOnly = true;
            this.Leaderboard.RowHeadersVisible = false;
            this.Leaderboard.Size = new System.Drawing.Size(245, 109);
            this.Leaderboard.TabIndex = 13;
            // 
            // NumberColumn
            // 
            this.NumberColumn.HeaderText = "Nr.";
            this.NumberColumn.Name = "NumberColumn";
            this.NumberColumn.ReadOnly = true;
            this.NumberColumn.Width = 25;
            // 
            // Player_Name
            // 
            this.Player_Name.HeaderText = "Player Name";
            this.Player_Name.Name = "Player_Name";
            this.Player_Name.ReadOnly = true;
            // 
            // ScoreColumn
            // 
            this.ScoreColumn.HeaderText = "Score";
            this.ScoreColumn.Name = "ScoreColumn";
            this.ScoreColumn.ReadOnly = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(229, 363);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // SnakeGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(402, 392);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Leaderboard);
            this.Controls.Add(this.BackgroundBox);
            this.Controls.Add(this.SpeedBox);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.SpecFoodBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Namebox);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.HeadBox);
            this.Controls.Add(this.MenuLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 439);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 439);
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake - Score: 0";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SnakeGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Leaderboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.ComboBox HeadBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Namebox;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox SpecFoodBox;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ComboBox SpeedBox;
        private System.Windows.Forms.ComboBox BackgroundBox;
        private System.Windows.Forms.DataGridView Leaderboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreColumn;
        private System.Windows.Forms.Button CloseButton;
    }
}

