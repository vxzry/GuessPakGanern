using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace GuessPakGanern
{
    public partial class Keyboard : UserControl
    {
        KeysConverter kCon;
        ucGameScreen gameScreen;
        public string keyPressed { get; set; }

        public Keyboard()
        {
            InitializeComponent();
            kCon = new KeysConverter();
        }

        public Keyboard (ucGameScreen gameScreen): this()
        {
            this.gameScreen = gameScreen;
        }

        private void Keyboard_Load(object sender, EventArgs e)
        {
            this.key1.Text = "A";
            this.key2.Text = "B";
            this.key3.Text = "C";
            this.key4.Text = "D";
            this.key5.Text = "E";
            this.key6.Text = "F";
            this.key7.Text = "G";
            this.key8.Text = "H";
            this.key9.Text = "I";
            this.key10.Text = "J";
            this.key11.Text = "K";
            this.key12.Text = "L";
            this.key13.Text = "M";
            this.key14.Text = "N";
            this.key15.Text = "O";
            this.key16.Text = "P";
            this.key17.Text = "Q";
            this.key18.Text = "R";
            this.key19.Text = "S";
            this.key20.Text = "T";
            this.key21.Text = "U";
            this.key22.Text = "V";
            this.key23.Text = "W";
            this.key24.Text = "X";
            this.key25.Text = "Y";
            this.key26.Text = "Z";
        }

        private void Keyboard_Leave(object sender, EventArgs e)
        {
            this.Focus();
        }
        
        public void Keyboard_KeyUp(object sender, KeyEventArgs e)
        {
            string keyvalue = kCon.ConvertToString(e.KeyData);

            Char value = ' ';
            Char.TryParse(keyvalue, out value);
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                if (!Char.IsControl(value))
                {
                    if (Char.IsLetter(value))
                    {
                        this.keyPressed = keyvalue.ToUpper();
                        if (this.gameScreen != null)
                        {
                            this.gameScreen.letter = this.keyPressed[0];
                            this.gameScreen.checkGuess();
                        }
                        foreach (var k in this.Controls.OfType<Key>())
                        {
                            if (this.keyPressed == k.Text)
                            {
                                k.clickButton();
                                k.Enabled = false;
                            }
                        }
                    }
                }
            }
    }

        private void key13_MouseClick(object sender, MouseEventArgs e)
        {
            Key key = sender as Key;
            if (key.Enabled)
            {
                this.keyPressed = key.Text;
                key.clickButton();
                key.Enabled = false;
                if (this.gameScreen != null)
                {
                    this.gameScreen.letter = this.keyPressed[0];
                    this.gameScreen.checkGuess();
                }
            }
        }

        public void disableKeys()
        {
            foreach (var k in this.Controls.OfType<Key>())
            {
                k.clickButton();
                k.ForeColor = Color.Red;
                k.Enabled = false;
            }
        }

        public void enableKeys()
        {
            foreach (var k in this.Controls.OfType<Key>())
            {
                k.resetButton();
                k.ForeColor = Color.Black;
                k.Enabled = true;
            }
        }
    }
}
