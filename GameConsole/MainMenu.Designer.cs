
namespace GameConsole
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ButtonList = new System.Windows.Forms.ImageList(this.components);
            this.lbGameConsole = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.PanelMenuButtons = new System.Windows.Forms.Panel();
            this.PanelGames = new System.Windows.Forms.Panel();
            this.btnCAndZ = new System.Windows.Forms.Button();
            this.btnSnakeGame = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.PanelSnakeDiff = new System.Windows.Forms.Panel();
            this.btnSnHard = new System.Windows.Forms.Button();
            this.btnSnEasy = new System.Windows.Forms.Button();
            this.btnSnMedium = new System.Windows.Forms.Button();
            this.PanelOptions = new System.Windows.Forms.Panel();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnWindowMode = new System.Windows.Forms.Button();
            this.btnSoundEffects = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.PanelMenuButtons.SuspendLayout();
            this.PanelGames.SuspendLayout();
            this.PanelSnakeDiff.SuspendLayout();
            this.PanelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonList
            // 
            this.ButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ButtonList.ImageStream")));
            this.ButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.ButtonList.Images.SetKeyName(0, "back.png");
            this.ButtonList.Images.SetKeyName(1, "exit.png");
            this.ButtonList.Images.SetKeyName(2, "home.png");
            this.ButtonList.Images.SetKeyName(3, "options.png");
            this.ButtonList.Images.SetKeyName(4, "play.png");
            // 
            // lbGameConsole
            // 
            this.lbGameConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbGameConsole.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbGameConsole.Location = new System.Drawing.Point(0, 0);
            this.lbGameConsole.Name = "lbGameConsole";
            this.lbGameConsole.Size = new System.Drawing.Size(852, 80);
            this.lbGameConsole.TabIndex = 0;
            this.lbGameConsole.Text = "GAME CONSOLE";
            this.lbGameConsole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.CausesValidation = false;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Impact", 36F);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Image = global::GameConsole.Properties.Resources.button;
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(233, 73);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Impact", 36F);
            this.btnOptions.ForeColor = System.Drawing.Color.White;
            this.btnOptions.Image = global::GameConsole.Properties.Resources.button;
            this.btnOptions.Location = new System.Drawing.Point(0, 76);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(233, 73);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.Text = "OPTIONS";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Impact", 36F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::GameConsole.Properties.Resources.button;
            this.btnExit.Location = new System.Drawing.Point(0, 155);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(233, 73);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PanelMenuButtons
            // 
            this.PanelMenuButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelMenuButtons.AutoSize = true;
            this.PanelMenuButtons.Controls.Add(this.btnExit);
            this.PanelMenuButtons.Controls.Add(this.btnPlay);
            this.PanelMenuButtons.Controls.Add(this.btnOptions);
            this.PanelMenuButtons.Location = new System.Drawing.Point(604, 194);
            this.PanelMenuButtons.Name = "PanelMenuButtons";
            this.PanelMenuButtons.Size = new System.Drawing.Size(236, 301);
            this.PanelMenuButtons.TabIndex = 4;
            // 
            // PanelGames
            // 
            this.PanelGames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelGames.AutoSize = true;
            this.PanelGames.Controls.Add(this.btnCAndZ);
            this.PanelGames.Controls.Add(this.btnSnakeGame);
            this.PanelGames.Location = new System.Drawing.Point(616, 0);
            this.PanelGames.Name = "PanelGames";
            this.PanelGames.Size = new System.Drawing.Size(236, 178);
            this.PanelGames.TabIndex = 5;
            this.PanelGames.Visible = false;
            // 
            // btnCAndZ
            // 
            this.btnCAndZ.BackColor = System.Drawing.Color.Transparent;
            this.btnCAndZ.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnCAndZ.FlatAppearance.BorderSize = 0;
            this.btnCAndZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCAndZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCAndZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAndZ.Font = new System.Drawing.Font("Impact", 19F);
            this.btnCAndZ.ForeColor = System.Drawing.Color.White;
            this.btnCAndZ.Image = global::GameConsole.Properties.Resources.button;
            this.btnCAndZ.Location = new System.Drawing.Point(0, 79);
            this.btnCAndZ.Name = "btnCAndZ";
            this.btnCAndZ.Size = new System.Drawing.Size(233, 73);
            this.btnCAndZ.TabIndex = 2;
            this.btnCAndZ.Text = "CROSSES AND ZEROS";
            this.btnCAndZ.UseVisualStyleBackColor = false;
            // 
            // btnSnakeGame
            // 
            this.btnSnakeGame.BackColor = System.Drawing.Color.Transparent;
            this.btnSnakeGame.CausesValidation = false;
            this.btnSnakeGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSnakeGame.FlatAppearance.BorderSize = 0;
            this.btnSnakeGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSnakeGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSnakeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnakeGame.Font = new System.Drawing.Font("Impact", 30F);
            this.btnSnakeGame.ForeColor = System.Drawing.Color.White;
            this.btnSnakeGame.Image = global::GameConsole.Properties.Resources.button;
            this.btnSnakeGame.Location = new System.Drawing.Point(0, 0);
            this.btnSnakeGame.Name = "btnSnakeGame";
            this.btnSnakeGame.Size = new System.Drawing.Size(233, 73);
            this.btnSnakeGame.TabIndex = 1;
            this.btnSnakeGame.Text = "SNAKE GAME";
            this.btnSnakeGame.UseVisualStyleBackColor = false;
            this.btnSnakeGame.Click += new System.EventHandler(this.btnSnakeGame_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Impact", 19F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::GameConsole.Properties.Resources.button;
            this.btnBack.Location = new System.Drawing.Point(0, 570);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(852, 78);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "BACK TO MAIN MENU";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PanelSnakeDiff
            // 
            this.PanelSnakeDiff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelSnakeDiff.AutoSize = true;
            this.PanelSnakeDiff.Controls.Add(this.btnSnHard);
            this.PanelSnakeDiff.Controls.Add(this.btnSnEasy);
            this.PanelSnakeDiff.Controls.Add(this.btnSnMedium);
            this.PanelSnakeDiff.Location = new System.Drawing.Point(14, 12);
            this.PanelSnakeDiff.Name = "PanelSnakeDiff";
            this.PanelSnakeDiff.Size = new System.Drawing.Size(236, 241);
            this.PanelSnakeDiff.TabIndex = 5;
            this.PanelSnakeDiff.Visible = false;
            // 
            // btnSnHard
            // 
            this.btnSnHard.BackColor = System.Drawing.Color.Transparent;
            this.btnSnHard.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnHard.FlatAppearance.BorderSize = 0;
            this.btnSnHard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSnHard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnHard.Font = new System.Drawing.Font("Impact", 36F);
            this.btnSnHard.ForeColor = System.Drawing.Color.White;
            this.btnSnHard.Image = global::GameConsole.Properties.Resources.button;
            this.btnSnHard.Location = new System.Drawing.Point(0, 155);
            this.btnSnHard.Name = "btnSnHard";
            this.btnSnHard.Size = new System.Drawing.Size(233, 73);
            this.btnSnHard.TabIndex = 3;
            this.btnSnHard.Text = "HARD";
            this.btnSnHard.UseVisualStyleBackColor = false;
            this.btnSnHard.Click += new System.EventHandler(this.btnSnHard_Click);
            // 
            // btnSnEasy
            // 
            this.btnSnEasy.BackColor = System.Drawing.Color.Transparent;
            this.btnSnEasy.CausesValidation = false;
            this.btnSnEasy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSnEasy.FlatAppearance.BorderSize = 0;
            this.btnSnEasy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSnEasy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnEasy.Font = new System.Drawing.Font("Impact", 36F);
            this.btnSnEasy.ForeColor = System.Drawing.Color.White;
            this.btnSnEasy.Image = global::GameConsole.Properties.Resources.button;
            this.btnSnEasy.Location = new System.Drawing.Point(0, 0);
            this.btnSnEasy.Margin = new System.Windows.Forms.Padding(0);
            this.btnSnEasy.Name = "btnSnEasy";
            this.btnSnEasy.Size = new System.Drawing.Size(233, 73);
            this.btnSnEasy.TabIndex = 1;
            this.btnSnEasy.Text = "EASY";
            this.btnSnEasy.UseVisualStyleBackColor = false;
            this.btnSnEasy.Click += new System.EventHandler(this.btnSnEasy_Click);
            // 
            // btnSnMedium
            // 
            this.btnSnMedium.BackColor = System.Drawing.Color.Transparent;
            this.btnSnMedium.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnSnMedium.FlatAppearance.BorderSize = 0;
            this.btnSnMedium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSnMedium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnMedium.Font = new System.Drawing.Font("Impact", 36F);
            this.btnSnMedium.ForeColor = System.Drawing.Color.White;
            this.btnSnMedium.Image = global::GameConsole.Properties.Resources.button;
            this.btnSnMedium.Location = new System.Drawing.Point(0, 76);
            this.btnSnMedium.Name = "btnSnMedium";
            this.btnSnMedium.Size = new System.Drawing.Size(233, 73);
            this.btnSnMedium.TabIndex = 2;
            this.btnSnMedium.Text = "MEDIUM";
            this.btnSnMedium.UseVisualStyleBackColor = false;
            this.btnSnMedium.Click += new System.EventHandler(this.btnSnMedium_Click);
            // 
            // PanelOptions
            // 
            this.PanelOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelOptions.AutoSize = true;
            this.PanelOptions.Controls.Add(this.btnMusic);
            this.PanelOptions.Controls.Add(this.btnSoundEffects);
            this.PanelOptions.Controls.Add(this.btnVolume);
            this.PanelOptions.Controls.Add(this.btnWindowMode);
            this.PanelOptions.Location = new System.Drawing.Point(306, 96);
            this.PanelOptions.Name = "PanelOptions";
            this.PanelOptions.Size = new System.Drawing.Size(236, 468);
            this.PanelOptions.TabIndex = 5;
            this.PanelOptions.Visible = false;
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.CausesValidation = false;
            this.btnVolume.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Font = new System.Drawing.Font("Impact", 25F);
            this.btnVolume.ForeColor = System.Drawing.Color.White;
            this.btnVolume.Image = global::GameConsole.Properties.Resources.button;
            this.btnVolume.Location = new System.Drawing.Point(0, 0);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(233, 73);
            this.btnVolume.TabIndex = 1;
            this.btnVolume.Text = "VOLUME: 100%";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnWindowMode
            // 
            this.btnWindowMode.BackColor = System.Drawing.Color.Transparent;
            this.btnWindowMode.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnWindowMode.FlatAppearance.BorderSize = 0;
            this.btnWindowMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnWindowMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnWindowMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindowMode.Font = new System.Drawing.Font("Impact", 18F);
            this.btnWindowMode.ForeColor = System.Drawing.Color.White;
            this.btnWindowMode.Image = global::GameConsole.Properties.Resources.button;
            this.btnWindowMode.Location = new System.Drawing.Point(0, 231);
            this.btnWindowMode.Name = "btnWindowMode";
            this.btnWindowMode.Size = new System.Drawing.Size(233, 73);
            this.btnWindowMode.TabIndex = 2;
            this.btnWindowMode.Text = "WINDOW MODE: MINIMIZED";
            this.btnWindowMode.UseVisualStyleBackColor = false;
            this.btnWindowMode.Click += new System.EventHandler(this.btnWindowMode_Click);
            // 
            // btnSoundEffects
            // 
            this.btnSoundEffects.BackColor = System.Drawing.Color.Transparent;
            this.btnSoundEffects.CausesValidation = false;
            this.btnSoundEffects.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSoundEffects.FlatAppearance.BorderSize = 0;
            this.btnSoundEffects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSoundEffects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSoundEffects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoundEffects.Font = new System.Drawing.Font("Impact", 19F);
            this.btnSoundEffects.ForeColor = System.Drawing.Color.White;
            this.btnSoundEffects.Image = global::GameConsole.Properties.Resources.button;
            this.btnSoundEffects.Location = new System.Drawing.Point(0, 77);
            this.btnSoundEffects.Margin = new System.Windows.Forms.Padding(0);
            this.btnSoundEffects.Name = "btnSoundEffects";
            this.btnSoundEffects.Size = new System.Drawing.Size(233, 73);
            this.btnSoundEffects.TabIndex = 3;
            this.btnSoundEffects.Text = "SOUND EFFECTS: ON";
            this.btnSoundEffects.UseVisualStyleBackColor = false;
            this.btnSoundEffects.Click += new System.EventHandler(this.btnSoundEffects_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnMusic.CausesValidation = false;
            this.btnMusic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Impact", 25F);
            this.btnMusic.ForeColor = System.Drawing.Color.White;
            this.btnMusic.Image = global::GameConsole.Properties.Resources.button;
            this.btnMusic.Location = new System.Drawing.Point(0, 155);
            this.btnMusic.Margin = new System.Windows.Forms.Padding(0);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(233, 73);
            this.btnMusic.TabIndex = 4;
            this.btnMusic.Text = "MUSIC: ON";
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(852, 648);
            this.Controls.Add(this.PanelOptions);
            this.Controls.Add(this.PanelSnakeDiff);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.PanelMenuButtons);
            this.Controls.Add(this.PanelGames);
            this.Controls.Add(this.lbGameConsole);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.PanelMenuButtons.ResumeLayout(false);
            this.PanelGames.ResumeLayout(false);
            this.PanelSnakeDiff.ResumeLayout(false);
            this.PanelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ButtonList;
        private System.Windows.Forms.Label lbGameConsole;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel PanelMenuButtons;
        private System.Windows.Forms.Panel PanelGames;
        private System.Windows.Forms.Button btnCAndZ;
        private System.Windows.Forms.Button btnSnakeGame;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel PanelSnakeDiff;
        private System.Windows.Forms.Button btnSnHard;
        private System.Windows.Forms.Button btnSnEasy;
        private System.Windows.Forms.Button btnSnMedium;
        private System.Windows.Forms.Panel PanelOptions;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnWindowMode;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnSoundEffects;
    }
}