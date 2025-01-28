
namespace OOP_Project_Alon_Itzik
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScoreText = new System.Windows.Forms.Label();
            this.LevelText = new System.Windows.Forms.Label();
            this.HPText = new System.Windows.Forms.Label();
            this.Lable_gameover = new System.Windows.Forms.Label();
            this.Lable_gameover_addscore = new System.Windows.Forms.Label();
            this.Lable_continue = new System.Windows.Forms.Label();
            this.Lable_scoreboard = new System.Windows.Forms.Label();
            this.Lable_new_game = new System.Windows.Forms.Label();
            this.Textbox_entername = new System.Windows.Forms.TextBox();
            this.Lable_score4 = new System.Windows.Forms.Label();
            this.Lable_score3 = new System.Windows.Forms.Label();
            this.Lable_score2 = new System.Windows.Forms.Label();
            this.Lable_score1 = new System.Windows.Forms.Label();
            this.bottomPictureBox = new System.Windows.Forms.PictureBox();
            this.Lable_ReturnToMenu = new System.Windows.Forms.Label();
            this.Label_credits = new System.Windows.Forms.Label();
            this.Label_scoreboard2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.MainTicking);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Black;
            this.ScoreText.Font = new System.Drawing.Font("Consolas", 27.75F);
            this.ScoreText.ForeColor = System.Drawing.Color.White;
            this.ScoreText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ScoreText.Location = new System.Drawing.Point(500, 760);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(139, 43);
            this.ScoreText.TabIndex = 3;
            this.ScoreText.Text = "SCORE:";
            // 
            // LevelText
            // 
            this.LevelText.AutoSize = true;
            this.LevelText.BackColor = System.Drawing.Color.Black;
            this.LevelText.Font = new System.Drawing.Font("Consolas", 27.75F);
            this.LevelText.ForeColor = System.Drawing.Color.White;
            this.LevelText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LevelText.Location = new System.Drawing.Point(0, 760);
            this.LevelText.Name = "LevelText";
            this.LevelText.Size = new System.Drawing.Size(139, 43);
            this.LevelText.TabIndex = 4;
            this.LevelText.Text = "LEVEL:";
            // 
            // HPText
            // 
            this.HPText.AutoSize = true;
            this.HPText.BackColor = System.Drawing.Color.Black;
            this.HPText.Font = new System.Drawing.Font("Consolas", 27.75F);
            this.HPText.ForeColor = System.Drawing.Color.White;
            this.HPText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HPText.Location = new System.Drawing.Point(258, 760);
            this.HPText.Name = "HPText";
            this.HPText.Size = new System.Drawing.Size(79, 43);
            this.HPText.TabIndex = 5;
            this.HPText.Text = "HP:";
            // 
            // Lable_gameover
            // 
            this.Lable_gameover.AutoSize = true;
            this.Lable_gameover.BackColor = System.Drawing.Color.Transparent;
            this.Lable_gameover.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold);
            this.Lable_gameover.ForeColor = System.Drawing.Color.White;
            this.Lable_gameover.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_gameover.Location = new System.Drawing.Point(169, 236);
            this.Lable_gameover.Name = "Lable_gameover";
            this.Lable_gameover.Size = new System.Drawing.Size(312, 75);
            this.Lable_gameover.TabIndex = 7;
            this.Lable_gameover.Text = "GAMEOVER";
            this.Lable_gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lable_gameover_addscore
            // 
            this.Lable_gameover_addscore.AutoSize = true;
            this.Lable_gameover_addscore.BackColor = System.Drawing.Color.Transparent;
            this.Lable_gameover_addscore.Font = new System.Drawing.Font("Consolas", 27.75F);
            this.Lable_gameover_addscore.ForeColor = System.Drawing.Color.White;
            this.Lable_gameover_addscore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_gameover_addscore.Location = new System.Drawing.Point(98, 398);
            this.Lable_gameover_addscore.Name = "Lable_gameover_addscore";
            this.Lable_gameover_addscore.Size = new System.Drawing.Size(479, 43);
            this.Lable_gameover_addscore.TabIndex = 8;
            this.Lable_gameover_addscore.Text = "CLICK HERE TO ADD SCORE";
            this.Lable_gameover_addscore.Click += new System.EventHandler(this.Lable_gameover_addscore_Click);
            // 
            // Lable_continue
            // 
            this.Lable_continue.AutoSize = true;
            this.Lable_continue.BackColor = System.Drawing.Color.Transparent;
            this.Lable_continue.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold);
            this.Lable_continue.ForeColor = System.Drawing.Color.White;
            this.Lable_continue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_continue.Location = new System.Drawing.Point(169, 307);
            this.Lable_continue.Name = "Lable_continue";
            this.Lable_continue.Size = new System.Drawing.Size(312, 75);
            this.Lable_continue.TabIndex = 7;
            this.Lable_continue.Text = "CONTINUE";
            this.Lable_continue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lable_continue.Click += new System.EventHandler(this.IntroLable1_Click);
            // 
            // Lable_scoreboard
            // 
            this.Lable_scoreboard.AutoSize = true;
            this.Lable_scoreboard.BackColor = System.Drawing.Color.Transparent;
            this.Lable_scoreboard.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold);
            this.Lable_scoreboard.ForeColor = System.Drawing.Color.White;
            this.Lable_scoreboard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_scoreboard.Location = new System.Drawing.Point(154, 463);
            this.Lable_scoreboard.Name = "Lable_scoreboard";
            this.Lable_scoreboard.Size = new System.Drawing.Size(382, 75);
            this.Lable_scoreboard.TabIndex = 7;
            this.Lable_scoreboard.Text = "SCOREBOARD";
            this.Lable_scoreboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lable_scoreboard.Click += new System.EventHandler(this.Scoreboard_Click);
            // 
            // Lable_new_game
            // 
            this.Lable_new_game.AutoSize = true;
            this.Lable_new_game.BackColor = System.Drawing.Color.Transparent;
            this.Lable_new_game.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold);
            this.Lable_new_game.ForeColor = System.Drawing.Color.White;
            this.Lable_new_game.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_new_game.Location = new System.Drawing.Point(169, 158);
            this.Lable_new_game.Name = "Lable_new_game";
            this.Lable_new_game.Size = new System.Drawing.Size(312, 75);
            this.Lable_new_game.TabIndex = 7;
            this.Lable_new_game.Text = "NEW GAME";
            this.Lable_new_game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lable_new_game.Click += new System.EventHandler(this.NewGameLable_Click);
            // 
            // Textbox_entername
            // 
            this.Textbox_entername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Textbox_entername.Location = new System.Drawing.Point(247, 332);
            this.Textbox_entername.Name = "Textbox_entername";
            this.Textbox_entername.Size = new System.Drawing.Size(150, 38);
            this.Textbox_entername.TabIndex = 9;
            // 
            // Lable_score4
            // 
            this.Lable_score4.AutoSize = true;
            this.Lable_score4.BackColor = System.Drawing.Color.Transparent;
            this.Lable_score4.Font = new System.Drawing.Font("Consolas", 20F);
            this.Lable_score4.ForeColor = System.Drawing.Color.White;
            this.Lable_score4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_score4.Location = new System.Drawing.Point(176, 512);
            this.Lable_score4.Name = "Lable_score4";
            this.Lable_score4.Size = new System.Drawing.Size(270, 32);
            this.Lable_score4.TabIndex = 8;
            this.Lable_score4.Tag = "Lable_score";
            this.Lable_score4.Text = "player score here";
            this.Lable_score4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lable_score3
            // 
            this.Lable_score3.AutoSize = true;
            this.Lable_score3.BackColor = System.Drawing.Color.Transparent;
            this.Lable_score3.Font = new System.Drawing.Font("Consolas", 20F);
            this.Lable_score3.ForeColor = System.Drawing.Color.White;
            this.Lable_score3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_score3.Location = new System.Drawing.Point(176, 423);
            this.Lable_score3.Name = "Lable_score3";
            this.Lable_score3.Size = new System.Drawing.Size(270, 32);
            this.Lable_score3.TabIndex = 8;
            this.Lable_score3.Tag = "Lable_score";
            this.Lable_score3.Text = "player score here";
            this.Lable_score3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lable_score2
            // 
            this.Lable_score2.AutoSize = true;
            this.Lable_score2.BackColor = System.Drawing.Color.Transparent;
            this.Lable_score2.Font = new System.Drawing.Font("Consolas", 20F);
            this.Lable_score2.ForeColor = System.Drawing.Color.White;
            this.Lable_score2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_score2.Location = new System.Drawing.Point(176, 332);
            this.Lable_score2.Name = "Lable_score2";
            this.Lable_score2.Size = new System.Drawing.Size(270, 32);
            this.Lable_score2.TabIndex = 8;
            this.Lable_score2.Tag = "Lable_score";
            this.Lable_score2.Text = "player score here";
            this.Lable_score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lable_score1
            // 
            this.Lable_score1.AutoSize = true;
            this.Lable_score1.BackColor = System.Drawing.Color.Transparent;
            this.Lable_score1.Font = new System.Drawing.Font("Consolas", 20F);
            this.Lable_score1.ForeColor = System.Drawing.Color.White;
            this.Lable_score1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_score1.Location = new System.Drawing.Point(176, 250);
            this.Lable_score1.Name = "Lable_score1";
            this.Lable_score1.Size = new System.Drawing.Size(270, 32);
            this.Lable_score1.TabIndex = 8;
            this.Lable_score1.Tag = "Lable_score";
            this.Lable_score1.Text = "player score here";
            this.Lable_score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPictureBox
            // 
            this.bottomPictureBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.bottomPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bottomPictureBox.Location = new System.Drawing.Point(0, 760);
            this.bottomPictureBox.Name = "bottomPictureBox";
            this.bottomPictureBox.Size = new System.Drawing.Size(669, 50);
            this.bottomPictureBox.TabIndex = 6;
            this.bottomPictureBox.TabStop = false;
            // 
            // Lable_ReturnToMenu
            // 
            this.Lable_ReturnToMenu.AutoSize = true;
            this.Lable_ReturnToMenu.BackColor = System.Drawing.Color.Black;
            this.Lable_ReturnToMenu.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold);
            this.Lable_ReturnToMenu.ForeColor = System.Drawing.Color.White;
            this.Lable_ReturnToMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lable_ReturnToMenu.Location = new System.Drawing.Point(1, 760);
            this.Lable_ReturnToMenu.Name = "Lable_ReturnToMenu";
            this.Lable_ReturnToMenu.Size = new System.Drawing.Size(283, 40);
            this.Lable_ReturnToMenu.TabIndex = 7;
            this.Lable_ReturnToMenu.Text = "return to menu";
            this.Lable_ReturnToMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lable_ReturnToMenu.Click += new System.EventHandler(this.ReturnToMain_Click);
            // 
            // Label_credits
            // 
            this.Label_credits.AutoSize = true;
            this.Label_credits.BackColor = System.Drawing.Color.Black;
            this.Label_credits.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold);
            this.Label_credits.ForeColor = System.Drawing.Color.White;
            this.Label_credits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_credits.Location = new System.Drawing.Point(1, 763);
            this.Label_credits.Name = "Label_credits";
            this.Label_credits.Size = new System.Drawing.Size(264, 40);
            this.Label_credits.TabIndex = 11;
            this.Label_credits.Text = "Powered by AI";
            this.Label_credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_credits.Click += new System.EventHandler(this.Label_credits_Click);
            // 
            // Label_scoreboard2
            // 
            this.Label_scoreboard2.AutoSize = true;
            this.Label_scoreboard2.BackColor = System.Drawing.Color.Transparent;
            this.Label_scoreboard2.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold);
            this.Label_scoreboard2.ForeColor = System.Drawing.Color.White;
            this.Label_scoreboard2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_scoreboard2.Location = new System.Drawing.Point(140, 83);
            this.Label_scoreboard2.Name = "Label_scoreboard2";
            this.Label_scoreboard2.Size = new System.Drawing.Size(417, 75);
            this.Label_scoreboard2.TabIndex = 7;
            this.Label_scoreboard2.Text = "SCOREBOARD:";
            this.Label_scoreboard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_scoreboard2.Click += new System.EventHandler(this.Scoreboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_Project_Alon_Itzik.Properties.Resources.Space_bg_4;
            this.ClientSize = new System.Drawing.Size(664, 807);
            this.Controls.Add(this.Label_credits);
            this.Controls.Add(this.Textbox_entername);
            this.Controls.Add(this.Lable_score1);
            this.Controls.Add(this.Lable_score2);
            this.Controls.Add(this.Lable_score3);
            this.Controls.Add(this.Lable_score4);
            this.Controls.Add(this.Lable_gameover_addscore);
            this.Controls.Add(this.Lable_ReturnToMenu);
            this.Controls.Add(this.Label_scoreboard2);
            this.Controls.Add(this.Lable_scoreboard);
            this.Controls.Add(this.Lable_new_game);
            this.Controls.Add(this.Lable_continue);
            this.Controls.Add(this.Lable_gameover);
            this.Controls.Add(this.HPText);
            this.Controls.Add(this.LevelText);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.bottomPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(680, 846);
            this.MinimumSize = new System.Drawing.Size(680, 846);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Invaders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bottomPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label LevelText;
        private System.Windows.Forms.Label HPText;
        private System.Windows.Forms.Label Lable_gameover;
        private System.Windows.Forms.Label Lable_gameover_addscore;
        private System.Windows.Forms.Label Lable_continue;
        private System.Windows.Forms.Label Lable_scoreboard;
        private System.Windows.Forms.Label Lable_new_game;
        private System.Windows.Forms.TextBox Textbox_entername;
        private System.Windows.Forms.Label Lable_score4;
        private System.Windows.Forms.Label Lable_score3;
        private System.Windows.Forms.Label Lable_score2;
        private System.Windows.Forms.Label Lable_score1;
        private System.Windows.Forms.PictureBox bottomPictureBox;
        private System.Windows.Forms.Label Lable_ReturnToMenu;
        private System.Windows.Forms.Label Label_credits;
        private System.Windows.Forms.Label Label_scoreboard2;
    }
}