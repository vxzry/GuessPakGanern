using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessPakGanern
{
    public partial class ucHomeScreen : UserControl
    {

        private mainForm mainForm;

        public ucHomeScreen()
        {
            InitializeComponent();
        }

        public ucHomeScreen(mainForm mainForm): this()
        {
            this.mainForm = mainForm;

        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            lbl.Font = new Font("Segoe UI Semibold", 25.25F, FontStyle.Bold);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            mainForm.Dispose();
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
                this.mainForm.changeScreen(new ucGameScreen(this.mainForm, (sender as Popup).Player));
            }

        }

        private void lblMultiplayer_Click(object sender, EventArgs e)
        {
            this.mainForm.changeScreen(new ucHighscore(this.mainForm));
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void lblHow_Click(object sender, EventArgs e)
        {
            HowToPlay how = new HowToPlay();
            how.FormClosing += How_FormClosing;
            how.ShowDialog();
        }

        private void How_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Focus();
        }
    }
}
