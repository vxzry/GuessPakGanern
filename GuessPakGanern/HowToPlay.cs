using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GuessPakGanern
{
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 5, Height - 5, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Size = new Size(135, 55);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(130, 50);
        }
    }
}
