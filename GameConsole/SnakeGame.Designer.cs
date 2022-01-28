
namespace GameConsole
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeGame));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SnakeImages = new System.Windows.Forms.ImageList(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.panelSnake = new System.Windows.Forms.Panel();
            this.panelLose = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.labelFinalScore = new System.Windows.Forms.Label();
            this.PbArena = new System.Windows.Forms.PictureBox();
            this.panelSnake.SuspendLayout();
            this.panelLose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbArena)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // SnakeImages
            // 
            this.SnakeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SnakeImages.ImageStream")));
            this.SnakeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.SnakeImages.Images.SetKeyName(0, "apple.png");
            this.SnakeImages.Images.SetKeyName(1, "darkGrass.png");
            this.SnakeImages.Images.SetKeyName(2, "grass.png");
            this.SnakeImages.Images.SetKeyName(3, "headDown.png");
            this.SnakeImages.Images.SetKeyName(4, "headLeft.png");
            this.SnakeImages.Images.SetKeyName(5, "HeadRight.png");
            this.SnakeImages.Images.SetKeyName(6, "headUp.png");
            this.SnakeImages.Images.SetKeyName(7, "horizontal.png");
            this.SnakeImages.Images.SetKeyName(8, "tailDown.png");
            this.SnakeImages.Images.SetKeyName(9, "tailLeft.png");
            this.SnakeImages.Images.SetKeyName(10, "tailRight.png");
            this.SnakeImages.Images.SetKeyName(11, "tailUp.png");
            this.SnakeImages.Images.SetKeyName(12, "turnDownLeft.png");
            this.SnakeImages.Images.SetKeyName(13, "turnDownRight.png");
            this.SnakeImages.Images.SetKeyName(14, "turnUpLeft.png");
            this.SnakeImages.Images.SetKeyName(15, "turnUpRight.png");
            this.SnakeImages.Images.SetKeyName(16, "vertical.png");
            // 
            // lbScore
            // 
            this.lbScore.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbScore.Font = new System.Drawing.Font("Impact", 30F);
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(0, 0);
            this.lbScore.Margin = new System.Windows.Forms.Padding(0);
            this.lbScore.Name = "lbScore";
            this.lbScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbScore.Size = new System.Drawing.Size(850, 48);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "Score: 0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelSnake
            // 
            this.panelSnake.BackColor = System.Drawing.Color.Transparent;
            this.panelSnake.Controls.Add(this.panelLose);
            this.panelSnake.Controls.Add(this.lbScore);
            this.panelSnake.Controls.Add(this.PbArena);
            this.panelSnake.Location = new System.Drawing.Point(1, 2);
            this.panelSnake.Name = "panelSnake";
            this.panelSnake.Size = new System.Drawing.Size(850, 850);
            this.panelSnake.TabIndex = 2;
            // 
            // panelLose
            // 
            this.panelLose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLose.Controls.Add(this.btnBack);
            this.panelLose.Controls.Add(this.btnPlayAgain);
            this.panelLose.Controls.Add(this.labelFinalScore);
            this.panelLose.Location = new System.Drawing.Point(198, 166);
            this.panelLose.Name = "panelLose";
            this.panelLose.Size = new System.Drawing.Size(448, 332);
            this.panelLose.TabIndex = 2;
            this.panelLose.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Impact", 19F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::GameConsole.Properties.Resources.button;
            this.btnBack.Location = new System.Drawing.Point(109, 124);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(233, 78);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK TO MAIN MENU";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.CausesValidation = false;
            this.btnPlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Impact", 30F);
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Image = global::GameConsole.Properties.Resources.button;
            this.btnPlayAgain.Location = new System.Drawing.Point(109, 48);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(233, 73);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // labelFinalScore
            // 
            this.labelFinalScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFinalScore.Font = new System.Drawing.Font("Impact", 30F);
            this.labelFinalScore.ForeColor = System.Drawing.Color.White;
            this.labelFinalScore.Location = new System.Drawing.Point(0, 0);
            this.labelFinalScore.Margin = new System.Windows.Forms.Padding(0);
            this.labelFinalScore.Name = "labelFinalScore";
            this.labelFinalScore.Size = new System.Drawing.Size(448, 48);
            this.labelFinalScore.TabIndex = 0;
            this.labelFinalScore.Text = "YOU LOST! FINAL SCORE: ";
            this.labelFinalScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PbArena
            // 
            this.PbArena.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PbArena.Location = new System.Drawing.Point(0, -3);
            this.PbArena.Name = "PbArena";
            this.PbArena.Size = new System.Drawing.Size(850, 850);
            this.PbArena.TabIndex = 0;
            this.PbArena.TabStop = false;
            this.PbArena.Click += new System.EventHandler(this.PbArena_Click);
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameConsole.Properties.Resources.darkGrass;
            this.ClientSize = new System.Drawing.Size(850, 827);
            this.Controls.Add(this.panelSnake);
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeGame_KeyDown);
            this.panelSnake.ResumeLayout(false);
            this.panelLose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbArena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.ImageList SnakeImages;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Panel panelSnake;
        private System.Windows.Forms.PictureBox PbArena;
        private System.Windows.Forms.Panel panelLose;
        private System.Windows.Forms.Label labelFinalScore;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnBack;
    }
}