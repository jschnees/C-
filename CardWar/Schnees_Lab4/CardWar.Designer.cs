namespace Schnees_Lab4
{
    partial class WarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarForm));
            this.ComputerLabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WinTexBox = new System.Windows.Forms.TextBox();
            this.PlayerWinsTextBox = new System.Windows.Forms.TextBox();
            this.ComputerWinsTextBox = new System.Windows.Forms.TextBox();
            this.PlayerWinsLabel = new System.Windows.Forms.Label();
            this.ComputerWinsLabel = new System.Windows.Forms.Label();
            this.CurrentScoresLabel = new System.Windows.Forms.Label();
            this.DrawButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PlayerPictureBox = new System.Windows.Forms.PictureBox();
            this.ComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputerLabel
            // 
            this.ComputerLabel.AccessibleDescription = "Computer Label";
            this.ComputerLabel.AccessibleName = "Computer Label";
            this.ComputerLabel.AutoSize = true;
            this.ComputerLabel.BackColor = System.Drawing.Color.Transparent;
            this.ComputerLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerLabel.ForeColor = System.Drawing.Color.White;
            this.ComputerLabel.Location = new System.Drawing.Point(51, 23);
            this.ComputerLabel.Name = "ComputerLabel";
            this.ComputerLabel.Size = new System.Drawing.Size(138, 25);
            this.ComputerLabel.TabIndex = 0;
            this.ComputerLabel.Text = "Computer";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AccessibleDescription = "Player Label";
            this.PlayerLabel.AccessibleName = "Player Label";
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.ForeColor = System.Drawing.Color.White;
            this.PlayerLabel.Location = new System.Drawing.Point(626, 23);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(101, 25);
            this.PlayerLabel.TabIndex = 0;
            this.PlayerLabel.Text = "Player";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.WinTexBox);
            this.panel1.Controls.Add(this.PlayerWinsTextBox);
            this.panel1.Controls.Add(this.ComputerWinsTextBox);
            this.panel1.Controls.Add(this.PlayerWinsLabel);
            this.panel1.Controls.Add(this.ComputerWinsLabel);
            this.panel1.Controls.Add(this.CurrentScoresLabel);
            this.panel1.Location = new System.Drawing.Point(237, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 272);
            this.panel1.TabIndex = 2;
            // 
            // WinTexBox
            // 
            this.WinTexBox.AccessibleDescription = "Wins TextBox";
            this.WinTexBox.AccessibleName = "Wins TextBox";
            this.WinTexBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.WinTexBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WinTexBox.Font = new System.Drawing.Font("BankGothic Lt BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinTexBox.ForeColor = System.Drawing.Color.White;
            this.WinTexBox.Location = new System.Drawing.Point(7, 215);
            this.WinTexBox.MaxLength = 100;
            this.WinTexBox.Multiline = true;
            this.WinTexBox.Name = "WinTexBox";
            this.WinTexBox.ReadOnly = true;
            this.WinTexBox.Size = new System.Drawing.Size(297, 38);
            this.WinTexBox.TabIndex = 0;
            this.WinTexBox.TabStop = false;
            this.WinTexBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WinTexBox.TextChanged += new System.EventHandler(this.WinTexBox_TextChanged);
            // 
            // PlayerWinsTextBox
            // 
            this.PlayerWinsTextBox.AccessibleDescription = "Player Wins TextBox";
            this.PlayerWinsTextBox.AccessibleName = "Player Wins TextBox";
            this.PlayerWinsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PlayerWinsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerWinsTextBox.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWinsTextBox.ForeColor = System.Drawing.Color.White;
            this.PlayerWinsTextBox.Location = new System.Drawing.Point(191, 163);
            this.PlayerWinsTextBox.MaxLength = 3;
            this.PlayerWinsTextBox.Name = "PlayerWinsTextBox";
            this.PlayerWinsTextBox.ReadOnly = true;
            this.PlayerWinsTextBox.Size = new System.Drawing.Size(97, 20);
            this.PlayerWinsTextBox.TabIndex = 0;
            this.PlayerWinsTextBox.TabStop = false;
            this.PlayerWinsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerWinsTextBox.TextChanged += new System.EventHandler(this.PlayerWinsTextBox_TextChanged);
            // 
            // ComputerWinsTextBox
            // 
            this.ComputerWinsTextBox.AccessibleDescription = "Computer Wins TextBox";
            this.ComputerWinsTextBox.AccessibleName = "Computer Wins TextBox";
            this.ComputerWinsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComputerWinsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComputerWinsTextBox.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerWinsTextBox.ForeColor = System.Drawing.Color.White;
            this.ComputerWinsTextBox.Location = new System.Drawing.Point(191, 91);
            this.ComputerWinsTextBox.MaxLength = 3;
            this.ComputerWinsTextBox.Name = "ComputerWinsTextBox";
            this.ComputerWinsTextBox.ReadOnly = true;
            this.ComputerWinsTextBox.Size = new System.Drawing.Size(97, 20);
            this.ComputerWinsTextBox.TabIndex = 0;
            this.ComputerWinsTextBox.TabStop = false;
            this.ComputerWinsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ComputerWinsTextBox.TextChanged += new System.EventHandler(this.ComputerWinsTextBox_TextChanged);
            // 
            // PlayerWinsLabel
            // 
            this.PlayerWinsLabel.AccessibleDescription = "Player Wins Label";
            this.PlayerWinsLabel.AccessibleName = "Player Wins Label";
            this.PlayerWinsLabel.AutoSize = true;
            this.PlayerWinsLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWinsLabel.ForeColor = System.Drawing.Color.White;
            this.PlayerWinsLabel.Location = new System.Drawing.Point(22, 163);
            this.PlayerWinsLabel.Name = "PlayerWinsLabel";
            this.PlayerWinsLabel.Size = new System.Drawing.Size(132, 19);
            this.PlayerWinsLabel.TabIndex = 0;
            this.PlayerWinsLabel.Text = "Player Wins";
            // 
            // ComputerWinsLabel
            // 
            this.ComputerWinsLabel.AccessibleDescription = "Computer Wins Label";
            this.ComputerWinsLabel.AccessibleName = "Computer Wins Label";
            this.ComputerWinsLabel.AutoSize = true;
            this.ComputerWinsLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerWinsLabel.ForeColor = System.Drawing.Color.White;
            this.ComputerWinsLabel.Location = new System.Drawing.Point(22, 87);
            this.ComputerWinsLabel.Name = "ComputerWinsLabel";
            this.ComputerWinsLabel.Size = new System.Drawing.Size(161, 19);
            this.ComputerWinsLabel.TabIndex = 1;
            this.ComputerWinsLabel.Text = "Computer Wins";
            // 
            // CurrentScoresLabel
            // 
            this.CurrentScoresLabel.AccessibleDescription = "Current Scores Label";
            this.CurrentScoresLabel.AccessibleName = "Current Scores Label";
            this.CurrentScoresLabel.AutoSize = true;
            this.CurrentScoresLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentScoresLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentScoresLabel.Location = new System.Drawing.Point(67, 18);
            this.CurrentScoresLabel.Name = "CurrentScoresLabel";
            this.CurrentScoresLabel.Size = new System.Drawing.Size(176, 19);
            this.CurrentScoresLabel.TabIndex = 0;
            this.CurrentScoresLabel.Text = "Current Scores";
            // 
            // DrawButton
            // 
            this.DrawButton.AccessibleDescription = "Draw Button";
            this.DrawButton.AccessibleName = "Draw Button";
            this.DrawButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawButton.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawButton.ForeColor = System.Drawing.Color.White;
            this.DrawButton.Location = new System.Drawing.Point(134, 401);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(91, 33);
            this.DrawButton.TabIndex = 1;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = false;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.AccessibleDescription = "New Game Button";
            this.NewGameButton.AccessibleName = "New Game Button";
            this.NewGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButton.ForeColor = System.Drawing.Color.White;
            this.NewGameButton.Location = new System.Drawing.Point(349, 401);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(91, 33);
            this.NewGameButton.TabIndex = 2;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleDescription = "Close Button";
            this.CloseButton.AccessibleName = "Close Button";
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(564, 401);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(91, 33);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PlayerPictureBox
            // 
            this.PlayerPictureBox.AccessibleDescription = "Player Picture Box";
            this.PlayerPictureBox.AccessibleName = "Player Picture Box";
            this.PlayerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PlayerPictureBox.Image")));
            this.PlayerPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("PlayerPictureBox.InitialImage")));
            this.PlayerPictureBox.Location = new System.Drawing.Point(576, 71);
            this.PlayerPictureBox.Name = "PlayerPictureBox";
            this.PlayerPictureBox.Size = new System.Drawing.Size(197, 300);
            this.PlayerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerPictureBox.TabIndex = 5;
            this.PlayerPictureBox.TabStop = false;
            this.PlayerPictureBox.Click += new System.EventHandler(this.PlayerPictureBox_Click);
            // 
            // ComputerPictureBox
            // 
            this.ComputerPictureBox.AccessibleDescription = "Computer Picture Box";
            this.ComputerPictureBox.AccessibleName = "Computer Picture Box";
            this.ComputerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ComputerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComputerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ComputerPictureBox.Image")));
            this.ComputerPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("ComputerPictureBox.InitialImage")));
            this.ComputerPictureBox.Location = new System.Drawing.Point(16, 71);
            this.ComputerPictureBox.Name = "ComputerPictureBox";
            this.ComputerPictureBox.Size = new System.Drawing.Size(197, 300);
            this.ComputerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ComputerPictureBox.TabIndex = 4;
            this.ComputerPictureBox.TabStop = false;
            this.ComputerPictureBox.Click += new System.EventHandler(this.ComputerPictureBox_Click);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AccessibleDescription = "Game Over Label";
            this.GameOverLabel.AccessibleName = "Game Over Label";
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.White;
            this.GameOverLabel.Location = new System.Drawing.Point(323, 23);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(151, 25);
            this.GameOverLabel.TabIndex = 0;
            this.GameOverLabel.Text = "Game Over";
            this.GameOverLabel.Visible = false;
            // 
            // WarForm
            // 
            this.AcceptButton = this.DrawButton;
            this.AccessibleDescription = "Card Battle";
            this.AccessibleName = "Card Battle";
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Schnees_Lab4.Properties.Resources.background;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(784, 455);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.PlayerPictureBox);
            this.Controls.Add(this.ComputerPictureBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.ComputerLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "WarForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card War";
            this.Load += new System.EventHandler(this.WarForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ComputerLabel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label CurrentScoresLabel;
        private System.Windows.Forms.Label ComputerWinsLabel;
        private System.Windows.Forms.Label PlayerWinsLabel;
        private System.Windows.Forms.TextBox PlayerWinsTextBox;
        private System.Windows.Forms.TextBox ComputerWinsTextBox;
        private System.Windows.Forms.TextBox WinTexBox;
        private System.Windows.Forms.PictureBox ComputerPictureBox;
        private System.Windows.Forms.PictureBox PlayerPictureBox;
        private System.Windows.Forms.Label GameOverLabel;
    }
}

