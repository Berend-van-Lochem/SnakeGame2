
namespace SnakeGame2
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            this.lblNamen = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.optEasy = new System.Windows.Forms.RadioButton();
            this.grpDifficulty = new System.Windows.Forms.GroupBox();
            this.optUltra = new System.Windows.Forms.RadioButton();
            this.optHard = new System.Windows.Forms.RadioButton();
            this.optMedium = new System.Windows.Forms.RadioButton();
            this.grpDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNamen
            // 
            this.lblNamen.AutoSize = true;
            this.lblNamen.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamen.Location = new System.Drawing.Point(46, 77);
            this.lblNamen.Name = "lblNamen";
            this.lblNamen.Size = new System.Drawing.Size(631, 48);
            this.lblNamen.TabIndex = 0;
            this.lblNamen.Text = "\'Snake\' door Berend, Jort en Issam";
            // 
            // btnStart
            // 
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(190, 175);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(265, 98);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAfsluiten.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfsluiten.Location = new System.Drawing.Point(190, 295);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(265, 98);
            this.btnAfsluiten.TabIndex = 2;
            this.btnAfsluiten.Text = "AFSLUITEN";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // optEasy
            // 
            this.optEasy.AutoSize = true;
            this.optEasy.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optEasy.Location = new System.Drawing.Point(0, 29);
            this.optEasy.Name = "optEasy";
            this.optEasy.Size = new System.Drawing.Size(89, 39);
            this.optEasy.TabIndex = 4;
            this.optEasy.TabStop = true;
            this.optEasy.Text = "Easy";
            this.optEasy.UseVisualStyleBackColor = true;
            // 
            // grpDifficulty
            // 
            this.grpDifficulty.Controls.Add(this.optUltra);
            this.grpDifficulty.Controls.Add(this.optHard);
            this.grpDifficulty.Controls.Add(this.optMedium);
            this.grpDifficulty.Controls.Add(this.optEasy);
            this.grpDifficulty.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDifficulty.Location = new System.Drawing.Point(495, 175);
            this.grpDifficulty.Name = "grpDifficulty";
            this.grpDifficulty.Size = new System.Drawing.Size(201, 218);
            this.grpDifficulty.TabIndex = 5;
            this.grpDifficulty.TabStop = false;
            this.grpDifficulty.Text = "Difficulty";
            // 
            // optUltra
            // 
            this.optUltra.AutoSize = true;
            this.optUltra.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optUltra.Location = new System.Drawing.Point(0, 164);
            this.optUltra.Name = "optUltra";
            this.optUltra.Size = new System.Drawing.Size(164, 39);
            this.optUltra.TabIndex = 7;
            this.optUltra.TabStop = true;
            this.optUltra.Text = "Ultra Hard";
            this.optUltra.UseVisualStyleBackColor = true;
            // 
            // optHard
            // 
            this.optHard.AutoSize = true;
            this.optHard.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHard.Location = new System.Drawing.Point(0, 119);
            this.optHard.Name = "optHard";
            this.optHard.Size = new System.Drawing.Size(93, 39);
            this.optHard.TabIndex = 6;
            this.optHard.TabStop = true;
            this.optHard.Text = "Hard";
            this.optHard.UseVisualStyleBackColor = true;
            // 
            // optMedium
            // 
            this.optMedium.AutoSize = true;
            this.optMedium.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optMedium.Location = new System.Drawing.Point(0, 74);
            this.optMedium.Name = "optMedium";
            this.optMedium.Size = new System.Drawing.Size(122, 39);
            this.optMedium.TabIndex = 5;
            this.optMedium.TabStop = true;
            this.optMedium.Text = "Medium";
            this.optMedium.UseVisualStyleBackColor = true;
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 429);
            this.Controls.Add(this.grpDifficulty);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblNamen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startscherm";
            this.grpDifficulty.ResumeLayout(false);
            this.grpDifficulty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.RadioButton optEasy;
        private System.Windows.Forms.GroupBox grpDifficulty;
        private System.Windows.Forms.RadioButton optUltra;
        private System.Windows.Forms.RadioButton optHard;
        private System.Windows.Forms.RadioButton optMedium;
    }
}