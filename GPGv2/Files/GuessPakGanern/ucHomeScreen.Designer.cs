namespace GuessPakGanern
{
    partial class ucHomeScreen
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
            this.lblExit = new System.Windows.Forms.Label();
            this.lblHow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.lblMultiplayer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblExit.Location = new System.Drawing.Point(-1, 208);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(289, 67);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "EXIT";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // lblHow
            // 
            this.lblHow.BackColor = System.Drawing.Color.Transparent;
            this.lblHow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHow.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHow.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblHow.Location = new System.Drawing.Point(-1, 141);
            this.lblHow.Name = "lblHow";
            this.lblHow.Size = new System.Drawing.Size(289, 67);
            this.lblHow.TabIndex = 3;
            this.lblHow.Text = "HOW TO PLAY";
            this.lblHow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHow.Click += new System.EventHandler(this.lblHow_Click);
            this.lblHow.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lblHow.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(-1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 67);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = global::GuessPakGanern.Properties.Resources.title;
            this.picTitle.Location = new System.Drawing.Point(95, 24);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(630, 266);
            this.picTitle.TabIndex = 6;
            this.picTitle.TabStop = false;
            // 
            // lblMultiplayer
            // 
            this.lblMultiplayer.BackColor = System.Drawing.Color.Transparent;
            this.lblMultiplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMultiplayer.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplayer.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblMultiplayer.Location = new System.Drawing.Point(-1, 74);
            this.lblMultiplayer.Name = "lblMultiplayer";
            this.lblMultiplayer.Size = new System.Drawing.Size(289, 67);
            this.lblMultiplayer.TabIndex = 4;
            this.lblMultiplayer.Text = "HIGHSCORE";
            this.lblMultiplayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMultiplayer.Click += new System.EventHandler(this.lblMultiplayer_Click);
            this.lblMultiplayer.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.lblMultiplayer.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::GuessPakGanern.Properties.Resources.homebutton_bg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMultiplayer);
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblHow);
            this.panel1.Location = new System.Drawing.Point(258, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 281);
            this.panel1.TabIndex = 13;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessPakGanern.Properties.Resources.bg;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picTitle);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblHow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label lblMultiplayer;
        private System.Windows.Forms.Panel panel1;
    }
}
