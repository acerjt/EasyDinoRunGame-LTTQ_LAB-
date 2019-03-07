namespace DinoRunTest
{
    partial class screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(screen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label_Score = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Cloud_3 = new System.Windows.Forms.PictureBox();
            this.Cloud_1 = new System.Windows.Forms.PictureBox();
            this.Cloud_2 = new System.Windows.Forms.PictureBox();
            this.Cactus = new System.Windows.Forms.PictureBox();
            this.LineRun = new System.Windows.Forms.PictureBox();
            this.Trex = new System.Windows.Forms.PictureBox();
            this.Label_HighScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Label_Score
            // 
            this.Label_Score.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Score.Location = new System.Drawing.Point(1357, 9);
            this.Label_Score.Name = "Label_Score";
            this.Label_Score.Size = new System.Drawing.Size(106, 47);
            this.Label_Score.TabIndex = 4;
            this.Label_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Cloud_3
            // 
            this.Cloud_3.Image = ((System.Drawing.Image)(resources.GetObject("Cloud_3.Image")));
            this.Cloud_3.Location = new System.Drawing.Point(113, 229);
            this.Cloud_3.Name = "Cloud_3";
            this.Cloud_3.Size = new System.Drawing.Size(100, 50);
            this.Cloud_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud_3.TabIndex = 7;
            this.Cloud_3.TabStop = false;
            // 
            // Cloud_1
            // 
            this.Cloud_1.Image = ((System.Drawing.Image)(resources.GetObject("Cloud_1.Image")));
            this.Cloud_1.Location = new System.Drawing.Point(549, 105);
            this.Cloud_1.Name = "Cloud_1";
            this.Cloud_1.Size = new System.Drawing.Size(100, 50);
            this.Cloud_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud_1.TabIndex = 6;
            this.Cloud_1.TabStop = false;
            // 
            // Cloud_2
            // 
            this.Cloud_2.Image = ((System.Drawing.Image)(resources.GetObject("Cloud_2.Image")));
            this.Cloud_2.Location = new System.Drawing.Point(876, 322);
            this.Cloud_2.Name = "Cloud_2";
            this.Cloud_2.Size = new System.Drawing.Size(100, 50);
            this.Cloud_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud_2.TabIndex = 5;
            this.Cloud_2.TabStop = false;
            // 
            // Cactus
            // 
            this.Cactus.BackColor = System.Drawing.Color.Transparent;
            this.Cactus.Image = ((System.Drawing.Image)(resources.GetObject("Cactus.Image")));
            this.Cactus.Location = new System.Drawing.Point(-30, 523);
            this.Cactus.Name = "Cactus";
            this.Cactus.Size = new System.Drawing.Size(24, 85);
            this.Cactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus.TabIndex = 2;
            this.Cactus.TabStop = false;
            // 
            // LineRun
            // 
            this.LineRun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LineRun.Image = ((System.Drawing.Image)(resources.GetObject("LineRun.Image")));
            this.LineRun.Location = new System.Drawing.Point(-4, 581);
            this.LineRun.Name = "LineRun";
            this.LineRun.Size = new System.Drawing.Size(2402, 28);
            this.LineRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LineRun.TabIndex = 1;
            this.LineRun.TabStop = false;
            // 
            // Trex
            // 
            this.Trex.BackColor = System.Drawing.Color.Transparent;
            this.Trex.Image = global::DinoRunTest.Properties.Resources.run;
            this.Trex.Location = new System.Drawing.Point(18, 503);
            this.Trex.Name = "Trex";
            this.Trex.Size = new System.Drawing.Size(88, 94);
            this.Trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Trex.TabIndex = 8;
            this.Trex.TabStop = false;
            // 
            // Label_HighScore
            // 
            this.Label_HighScore.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_HighScore.Location = new System.Drawing.Point(1118, 9);
            this.Label_HighScore.Name = "Label_HighScore";
            this.Label_HighScore.Size = new System.Drawing.Size(229, 47);
            this.Label_HighScore.TabIndex = 9;
            this.Label_HighScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 647);
            this.Controls.Add(this.Label_HighScore);
            this.Controls.Add(this.Trex);
            this.Controls.Add(this.Cloud_3);
            this.Controls.Add(this.Cloud_1);
            this.Controls.Add(this.Cloud_2);
            this.Controls.Add(this.Label_Score);
            this.Controls.Add(this.Cactus);
            this.Controls.Add(this.LineRun);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "screen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Cloud_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LineRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Cactus;
        private System.Windows.Forms.Label Label_Score;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Cloud_2;
        private System.Windows.Forms.PictureBox Cloud_1;
        private System.Windows.Forms.PictureBox Cloud_3;
        private System.Windows.Forms.PictureBox Trex;
        private System.Windows.Forms.Label Label_HighScore;
    }
}

