
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbArena = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
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
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Impact", 30F);
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(3, 0);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(151, 48);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "Score: 0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PbArena);
            this.panel1.Controls.Add(this.lbScore);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 851);
            this.panel1.TabIndex = 2;
            // 
            // PbArena
            // 
            this.PbArena.Location = new System.Drawing.Point(0, 0);
            this.PbArena.Name = "PbArena";
            this.PbArena.Size = new System.Drawing.Size(852, 850);
            this.PbArena.TabIndex = 0;
            this.PbArena.TabStop = false;
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameConsole.Properties.Resources.darkGrass;
            this.ClientSize = new System.Drawing.Size(1169, 986);
            this.Controls.Add(this.panel1);
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeGame_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbArena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.ImageList SnakeImages;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbArena;
    }
}