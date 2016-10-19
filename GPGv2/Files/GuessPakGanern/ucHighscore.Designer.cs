namespace GuessPakGanern
{
    partial class ucHighscore
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Image = global::GuessPakGanern.Properties.Resources.mainmenu;
            this.picBack.Location = new System.Drawing.Point(7, 383);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(144, 148);
            this.picBack.TabIndex = 1;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            this.picBack.MouseEnter += new System.EventHandler(this.picBack_MouseEnter);
            this.picBack.MouseLeave += new System.EventHandler(this.picBack_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GuessPakGanern.Properties.Resources.highscore1;
            this.pictureBox1.Location = new System.Drawing.Point(170, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 110);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.txtName.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtName.Location = new System.Drawing.Point(168, 187);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(420, 344);
            this.txtName.TabIndex = 5;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtScore.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.txtScore.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtScore.Location = new System.Drawing.Point(582, 187);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(149, 344);
            this.txtScore.TabIndex = 6;
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ucHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessPakGanern.Properties.Resources.bg;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtName);
            this.Name = "ucHighscore";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.Highscore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtScore;
    }
}
