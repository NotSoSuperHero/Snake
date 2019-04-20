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
    "\nPress ENTER to begin.";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SnakeGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(402, 392);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MenuLabel;
    }
}

