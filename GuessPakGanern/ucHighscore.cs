using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GuessPakGanern
{
    public partial class ucHighscore : UserControl
    {
        mainForm mainForm;
        public ucHighscore(mainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void picBack_MouseLeave(object sender, EventArgs e)
        {
            this.picBack.Image = global::GuessPakGanern.Properties.Resources.mainmenu;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.mainForm.changeScreen(new ucHomeScreen(mainForm));
        }

        private void Highscore_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\" + "highscore.csv";
            if (File.Exists(path))
            {
                List<HighScore> highscores = new List<HighScore>();
                using (var reader = new StreamReader(File.OpenRead(path)))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(line.ToString()))
                        {
                            var values = line.Split(',');
                            HighScore hs = new HighScore(values[0], Int32.Parse(values[1]));
                            highscores.Add(hs);
                        }
                    }
                }
                List<HighScore> SortedList = highscores.OrderByDescending(x => x.Score).ToList();
                this.txtName.ResetText();
                this.txtScore.ResetText();
                for (int i = 0; i < SortedList.Count; i++) {
                    this.txtName.Text += (i==9?(i+1).ToString():("0"+(i+1))) + ".   " + SortedList[i].Player + Environment.NewLine;
                    this.txtScore.Text+= SortedList[i].Score + "   " + Environment.NewLine;
                }
            }
            
        }

        private void picBack_MouseEnter(object sender, EventArgs e)
        {
            this.picBack.Image = global::GuessPakGanern.Properties.Resources.maunmenu_selected;
        }
    }
}
