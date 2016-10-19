using System;
using System.Drawing;
using System.Windows.Forms;

namespace GuessPakGanern
{
    public partial class Key : Button
    {
        public Key()
        {
            InitializeComponent();
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            clickButton();
        }

        public void clickButton()
        {
            this.BackgroundImage = Properties.Resources.button_selected;
            this.Cursor = Cursors.Default;
        }

        public void resetButton()
        {
            this.BackgroundImage = Properties.Resources.button_selected;
            
            this.Cursor = Cursors.Hand;
            this.Enabled = true;
        }
    }
}
