using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GuessPakGanern
{
    public partial class Popup : Form
    {
        public int result;
        public string Title
        {
            get { return title.Text; }
            set { this.title.Text = value; }
        }
        public string Body
        {
            get { return title.Text; }
            set { this.body.Text = value; }
        }
        public string Button1
        {
            get { return title.Text; }
            set { this.button1.Text = value; }
        }
        public string Button2
        {
            get { return title.Text; }
            set { this.button2.Text = value; }
        }
        public Int32 Result
        {
            get { return this.result; }
        }

        public string Player
        {
            get { return this.txtbox.Text; }
        }
        public Popup()
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

        public Popup(string title, string body, string button1, string button2): this()
        {
            this.Title = title;
            this.Body = body;
            this.Button1 = button1;
            this.Button2 = button2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.result = 2;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.result = 1;
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Size = new System.Drawing.Size(145, 53);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Size = new System.Drawing.Size(142, 50);
        }
        
        public void showTextBox()
        {
            this.body.Enabled = false;
            this.body.TextAlign = ContentAlignment.TopCenter;
            this.txtbox.Visible = true;
            this.txtbox.Focus();
        }

    }
}
