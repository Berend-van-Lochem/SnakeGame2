
namespace SnakeGame2
{
    partial class Speelveld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Speelveld));
            this.picSpeelveld = new System.Windows.Forms.PictureBox();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.timTimeTracker = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSpeelveld)).BeginInit();
            this.SuspendLayout();
            // 
            // picSpeelveld
            // 
            this.picSpeelveld.Location = new System.Drawing.Point(12, 12);
            this.picSpeelveld.Name = "picSpeelveld";
            this.picSpeelveld.Size = new System.Drawing.Size(564, 535);
            this.picSpeelveld.TabIndex = 0;
            this.picSpeelveld.TabStop = false;
            // 
            // timTimer
            // 
            this.timTimer.Interval = 500;
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "Bonus.png");
            this.ImgList.Images.SetKeyName(1, "Snake-Body.png");
            this.ImgList.Images.SetKeyName(2, "Snake-Head.png");
            this.ImgList.Images.SetKeyName(3, "Muur.png");
            this.ImgList.Images.SetKeyName(4, "bomb.png");
            // 
            // timTimeTracker
            // 
            this.timTimeTracker.Interval = 1000;
            this.timTimeTracker.Tick += new System.EventHandler(this.timTimeTracker_Tick);
            // 
            // Speelveld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 559);
            this.Controls.Add(this.picSpeelveld);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Speelveld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake ";
            this.Load += new System.EventHandler(this.Speelveld_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Speelveld_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picSpeelveld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpeelveld;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.Timer timTimeTracker;
        public System.Windows.Forms.Timer timTimer;
    }
}