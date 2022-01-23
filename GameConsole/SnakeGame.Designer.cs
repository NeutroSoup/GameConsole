
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
            this.PbArena = new System.Windows.Forms.PictureBox();
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
            // PbArena
            // 
            this.PbArena.Location = new System.Drawing.Point(0, 0);
            this.PbArena.Name = "PbArena";
            this.PbArena.Size = new System.Drawing.Size(850, 850);
            this.PbArena.TabIndex = 0;
            this.PbArena.TabStop = false;
            // 
            // SnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameConsole.Properties.Resources.darkGrass;
            this.ClientSize = new System.Drawing.Size(849, 848);
            this.Controls.Add(this.PbArena);
            this.Name = "SnakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeGame";
            this.Load += new System.EventHandler(this.SnakeGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PbArena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.ImageList SnakeImages;
        private System.Windows.Forms.PictureBox PbArena;
    }
}