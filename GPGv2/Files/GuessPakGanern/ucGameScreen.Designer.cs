namespace GuessPakGanern
{
    partial class ucGameScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lifePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.picGiveUp = new System.Windows.Forms.PictureBox();
            this.picNewGame = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGiveUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewGame)).BeginInit();
            this.SuspendLayout();
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.Image = global::GuessPakGanern.Properties.Resources.mainmenu;
            this.picBack.Location = new System.Drawing.Point(7, 394);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(144, 148);
            this.picBack.TabIndex = 0;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            this.picBack.MouseEnter += new System.EventHandler(this.picBack_MouseEnter);
            this.picBack.MouseLeave += new System.EventHandler(this.picBack_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Image = global::GuessPakGanern.Properties.Resources.wordbg;
            this.label1.Location = new System.Drawing.Point(64, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(668, 249);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLife
            // 
            this.lblLife.BackColor = System.Drawing.Color.Transparent;
            this.lblLife.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.lblLife.Location = new System.Drawing.Point(16, 3);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(106, 45);
            this.lblLife.TabIndex = 2;
            this.lblLife.Text = "LIVES : ";
            this.lblLife.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.lblScore.Location = new System.Drawing.Point(669, 3);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(116, 45);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRound
            // 
            this.lblRound.BackColor = System.Drawing.Color.Transparent;
            this.lblRound.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.lblRound.Location = new System.Drawing.Point(379, 3);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(114, 45);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "ROUND ";
            this.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GuessPakGanern.Properties.Resources.header;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.lifePanel);
            this.panel1.Controls.Add(this.lblLife);
            this.panel1.Controls.Add(this.lblRound);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 3;
            // 
            // lifePanel
            // 
            this.lifePanel.BackColor = System.Drawing.Color.Transparent;
            this.lifePanel.Location = new System.Drawing.Point(77, 10);
            this.lifePanel.Name = "lifePanel";
            this.lifePanel.Size = new System.Drawing.Size(296, 34);
            this.lifePanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(583, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "SCORE : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picGiveUp
            // 
            this.picGiveUp.BackColor = System.Drawing.Color.Transparent;
            this.picGiveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picGiveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGiveUp.Image = global::GuessPakGanern.Properties.Resources.giveup;
            this.picGiveUp.Location = new System.Drawing.Point(643, 394);
            this.picGiveUp.Name = "picGiveUp";
            this.picGiveUp.Size = new System.Drawing.Size(144, 148);
            this.picGiveUp.TabIndex = 0;
            this.picGiveUp.TabStop = false;
            this.picGiveUp.Click += new System.EventHandler(this.picGiveUp_Click);
            this.picGiveUp.MouseEnter += new System.EventHandler(this.picGiveUp_MouseEnter);
            this.picGiveUp.MouseLeave += new System.EventHandler(this.picGiveUp_MouseLeave);
            // 
            // picNewGame
            // 
            this.picNewGame.BackColor = System.Drawing.Color.Transparent;
            this.picNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNewGame.Image = global::GuessPakGanern.Properties.Resources.newgame;
            this.picNewGame.Location = new System.Drawing.Point(643, 394);
            this.picNewGame.Name = "picNewGame";
            this.picNewGame.Size = new System.Drawing.Size(144, 148);
            this.picNewGame.TabIndex = 4;
            this.picNewGame.TabStop = false;
            this.picNewGame.Click += new System.EventHandler(this.picNewGame_Click);
            this.picNewGame.MouseEnter += new System.EventHandler(this.picNewGame_MouseEnter);
            this.picNewGame.MouseLeave += new System.EventHandler(this.picNewGame_MouseLeave);
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Tw Cen MT", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(66)))), ((int)(((byte)(111)))));
            this.lblGameOver.Location = new System.Drawing.Point(227, 54);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(357, 45);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessPakGanern.Properties.Resources._50861_O6IQSM;
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picGiveUp);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picNewGame);
            this.Name = "ucGameScreen";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGiveUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBack;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblLife;
        public System.Windows.Forms.Label lblScore;
        public System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel lifePanel;
        private System.Windows.Forms.PictureBox picGiveUp;
        private System.Windows.Forms.PictureBox picNewGame;
        public System.Windows.Forms.Label lblGameOver;
    }
}
