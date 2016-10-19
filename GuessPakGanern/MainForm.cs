using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GuessPakGanern
{
    public partial class mainForm : Form
    {
        int i = -324;
        public mainForm()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        internal static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void AnimateTitle()
        {
            this.picTitle.Location = new Point(95,i);
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picTitle.Location.Y < 24)
                picTitle.Location = new Point(95, i += 10);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            AnimateTitle();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Font = new Font("Segoe UI Semibold", 25.25F, FontStyle.Bold);

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);

        }

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup popup = new Popup("PLAYER", "\nEnter your name: ", "Cancel", "Continue");
            popup.showTextBox();
            popup.FormClosing += EnterName_Popup_FormClosing; ;
            popup.ShowDialog();
        }

        private void EnterName_Popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((sender as Popup).Result == 2)
            {
                this.changeScreen(new ucGameScreen(this, (sender as Popup).Player));
            }
        }

        public void changeScreen(UserControl uc)
        {
            this.Controls.Clear();
            this.Controls.Add(uc);
        }

        private void lblMultiplayer_Click(object sender, EventArgs e)
        {
            changeScreen(new ucHighscore(this));
        }

        private void lblHow_Click(object sender, EventArgs e)
        {
            new HowToPlay().ShowDialog();
        }
    }
}
