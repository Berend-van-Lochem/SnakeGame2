
namespace SnakeGame2
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.lblRestart = new System.Windows.Forms.Label();
            this.btnJa = new System.Windows.Forms.Button();
            this.btnNee = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.Location = new System.Drawing.Point(111, 55);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(423, 45);
            this.lblRestart.TabIndex = 0;
            this.lblRestart.Text = "GAME OVER, RESTART?";
            // 
            // btnJa
            // 
            this.btnJa.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnJa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJa.Location = new System.Drawing.Point(96, 168);
            this.btnJa.Name = "btnJa";
            this.btnJa.Size = new System.Drawing.Size(128, 91);
            this.btnJa.TabIndex = 1;
            this.btnJa.Text = "JA!";
            this.btnJa.UseVisualStyleBackColor = true;
            // 
            // btnNee
            // 
            this.btnNee.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNee.Location = new System.Drawing.Point(259, 168);
            this.btnNee.Name = "btnNee";
            this.btnNee.Size = new System.Drawing.Size(128, 91);
            this.btnNee.TabIndex = 2;
            this.btnNee.Text = "Nee, ik wil terug naar het menu!";
            this.btnNee.UseVisualStyleBackColor = true;
            // 
            // btnAbort
            // 
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbort.Location = new System.Drawing.Point(421, 168);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(128, 91);
            this.btnAbort.TabIndex = 3;
            this.btnAbort.Text = "Nee, sluit het spel af!";
            this.btnAbort.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(189, 112);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 41);
            this.lblScore.TabIndex = 4;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 301);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnNee);
            this.Controls.Add(this.btnJa);
            this.Controls.Add(this.lblRestart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.Button btnJa;
        private System.Windows.Forms.Button btnNee;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label lblScore;
    }
}