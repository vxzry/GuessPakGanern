using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace GuessPakGanern
{
    public partial class ucGameScreen : UserControl
    {
        //VARIABLE DECLARATION
        public string Player
        {
            get { return !string.IsNullOrEmpty(player) ? player : "~Alien~"; }
            set { player = !string.IsNullOrEmpty(value) ? value : "~Alien~"; }
        }
        public int Score
        {
            get { return score >= 0 ? score : 0; }
            set { score = value >= 0 ? value : 0; }
        }
        public bool boolHighscore { get; private set; }
        private Keyboard keyboard;
        private mainForm mainForm;
        int LIFE = 8;
        int round;
        private int life;
        string word;
        string displayWord;
        public char letter;
        int score;
        int correctGuess = 0;
        string player;
        List<string> wordList;
        List<int> doneIndex; //to avoid repetition of words
        List<Heart> lives;
        Random random;
        
        //CONSTRUCTORS
        public ucGameScreen()
        {
            InitializeComponent();
            setUpKeyboard();
            newGame();
        }
        public ucGameScreen(mainForm mainForm, string player): this()
        {
            this.mainForm = mainForm;
            this.Player = player;
        }



        //FUNCTIONS
        #region
        
        private void newGame()
        {
            random = new Random();
            score= 0;
            round = 0;
            doneIndex = new List<int>();

            picGiveUp.BringToFront();
            picNewGame.SendToBack();

            loadWordList();
            newRound();
        }
        
        private void newRound()
        {
            correctGuess = 0;
            letter = '@';
            word = "";
            displayWord = "";
            life = LIFE;
            lives = new List<Heart>();
            getWord();
            round++;
            lblGameOver.Visible = false;
            updateRound();
            updateScore();
            updateLives();

            keyboard.disableKeys();
            keyboard.enableKeys();
        }

        private void loadWordList()
        {
            //Get wordlist from file
            wordList = new List<string>();
            
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "GuessPakGanern.WordList.txt";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (reader.Peek() != -1)
                    {
                        wordList.Add(reader.ReadLine().Trim());
                    }
                }
            }
        }

        private void getWord()
        {
            if (doneIndex.Count == wordList.Count)
            {
                Popup popup = new Popup("Congratulations!!!", "We ran out of words\nDo you wish to start a new game?", "Main Menu", "New Game");
                popup.FormClosed += NoWordsLeft_Popup_FormClosed;
                popup.ShowDialog();
                endGame();
            }else { 
                int currentIndex = random.Next(0, wordList.Count);
                //check if the number is already used
                while (doneIndex.Contains(currentIndex))
                {
                    currentIndex = random.Next(0, wordList.Count);
                }
             
                doneIndex.Add(currentIndex);
                word = wordList[currentIndex];
                displayWord = word;
                foreach (char c in displayWord)
                {
                    displayWord = displayWord.Replace(c, '_');
                }
                foreach (char c in displayWord)
                {
                    label1.Text += c + " ";
                }
                display();
            }
        }

        public void display()
        {
            label1.Text = " ";
            foreach (char c in displayWord)
            {
                label1.Text += c + "  ";
            }
        }

        private void saveScore()
        {
            boolHighscore = false;
            //get current score
            HighScore currentHS = new HighScore(this.Player, this.Score);
            List<HighScore> highscores = new List<HighScore>();
            //create highscore.csv file if not found
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\" + "highscore.csv";

            if (File.Exists(path))
            {
                //read highscore.csv file
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
                highscores = highscores.OrderByDescending(x => x.Score).ToList();
                //if current score is the NEW highscore (idk how to englsh)
                if (currentHS.Score > highscores[0].Score)
                {
                    boolHighscore = true;
                }
                highscores.Add(currentHS);
                //Sort list to get top 10 (only save top 10)
                List<HighScore> SortedList = highscores.OrderByDescending(x => x.Score).ToList();
                
                //write to file
                string scores = "";
                for (int i = 0; i < (SortedList.Count>=10?10:SortedList.Count); i++)
                {
                    scores += SortedList[i].Player + "," + SortedList[i].Score + Environment.NewLine;
                }

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(scores);
                }

            }
            else
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(currentHS.Player + "," + currentHS.Score);
                }
            }
        }

        private void updateRound()
        {
            lblRound.Text = "ROUND " + round;
        }

        private void updateScore()
        {
            lblScore.Text = score.ToString();
        }

        private void updateLives()
        {
            this.lifePanel.Controls.Clear();

            for (int i = 0, x=18; i < life; i++, x+=34)
            {
                Heart heart = new Heart();
                heart.Location = new Point(x,5);
                heart.Size = new Size(28, 22);
                
                this.lifePanel.Controls.Add(heart);
            }
        }

        public void checkGuess() {
            bool found = false;
            
            for(int i = 0; i<word.Length; i++)
            {
                if(char.Equals(letter,word[i]))
                {
                    char[] c = displayWord.ToCharArray();
                    c[i] = letter;
                    displayWord = new string(c);
                    display();

                    found = true;
                    score += 10;
                    updateScore();
                    ++correctGuess;
                    if (correctGuess == word.Length)
                    {
                        completeWord();
                    }
                }
            }

            if (!found)
            {
                decreaseLife();
                if (life < 1)
                    endGame();
            }
        }

        private void completeWord()
        {
            updateScore();

            Popup popup = new Popup("Congratulations!!!", "You got the word!\nContinue to the next round?", "End Game", "Next Round");
            popup.FormClosed += Completed_Popup_FormClosed;
            popup.ShowDialog();
        }

        private void decreaseLife()
        {
            --life;
            updateLives();
        }

        private void endGame()
        {
            keyboard.disableKeys();
            //Display word
            label1.Text = " ";
            foreach (char c in word)
            {
                label1.Text += c + "  ";
            }

            lblGameOver.Visible = true;

            picGiveUp.SendToBack();
            picNewGame.BringToFront();
            saveScore();
            //if high score - display popup :) :) :) 
            if (boolHighscore)
            {
                Popup popup = new Popup("Congratulations " +Player+ "!!!", "New Highscore!", "Highscores", "Okay");
                popup.FormClosed += Highscore_Popup_FormClosed;
                popup.ShowDialog();
            }
        }

        private void setUpKeyboard()
        {
            this.keyboard = new GuessPakGanern.Keyboard(this);
            this.keyboard.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.keyboard.BackColor = System.Drawing.Color.Transparent;
            this.keyboard.BackgroundImage = global::GuessPakGanern.Properties.Resources.keyboard_bg;
            this.keyboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.keyboard.CausesValidation = false;
            this.keyboard.keyPressed = null;
            this.keyboard.Name = "keyboard";
            this.keyboard.Size = new System.Drawing.Size(486, 188);
            this.keyboard.Location = new System.Drawing.Point((this.Width - this.keyboard.Width)/2, 393);
            this.keyboard.TabIndex = 2;
            this.Controls.Add(this.keyboard);
        }

        #endregion

        //EVENTS
        #region 

        private void NoWordsLeft_Popup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((sender as Popup).Result == 1)
            {
                this.mainForm.changeScreen(new ucHomeScreen(mainForm));
            }
            else
            {
                this.newGame();
            }
        }


        private void Highscore_Popup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((sender as Popup).Result == 1)
            {
                this.mainForm.changeScreen(new ucHighscore(mainForm));
            }
        }

        private void picBack_MouseLeave(object sender, EventArgs e)
        {
            this.picBack.Image = global::GuessPakGanern.Properties.Resources.mainmenu;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Popup popup = new Popup("Are you sure?", "You are leaving your current game to go back to the main menu", "Cancel", "Okay");
            popup.FormClosing += Back_Popup_FormClosing;
            popup.ShowDialog();
        }

        private void Back_Popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((sender as Popup).Result == 2)
                this.mainForm.changeScreen(new ucHomeScreen(mainForm));
        }

        private void picBack_MouseEnter(object sender, EventArgs e)
        {
            this.picBack.Image = global::GuessPakGanern.Properties.Resources.maunmenu_selected;
        }

        private void picGiveUp_Click(object sender, EventArgs e)
        {
            Popup popup = new Popup("Are you sure?", "Are you really giving up?", "Back to Game", "Give Up");
            popup.FormClosing += GiveUp_Popup_FormClosing;
            popup.ShowDialog();
        }

        private void GiveUp_Popup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if((sender as Popup).Result==2)
                this.endGame();
        }

        private void picGiveUp_MouseEnter(object sender, EventArgs e)
        {
            this.picGiveUp.Image = global::GuessPakGanern.Properties.Resources.giveup_selected;
        }

        private void picGiveUp_MouseLeave(object sender, EventArgs e)
        {
            this.picGiveUp.Image = global::GuessPakGanern.Properties.Resources.giveup;
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //string keyvalue = kCon.ConvertToString(e.KeyData);

            //Char value = ' ';
            //Char.TryParse(keyvalue, out value);

            //if (Char.IsLetter(value))
            //{
            //    this.Keyboard.keyPressed = keyvalue.ToUpper();
            //    foreach (var k in this.Keyboard.Controls.OfType<Key>())
            //    {
            //        if (this.Keyboard.keyPressed == k.Text)
            //        {
            //            k.clickButton();
            //            k.Enabled = false;

            //        }
            //    }
            //}
            

        }
        
        private void GameScreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string keyvalue = e.KeyChar.ToString();

            //if (Char.IsLetter(e.KeyChar))
            //{
            //    this.Keyboard.keyPressed = keyvalue.ToUpper();
            //    foreach (var k in this.Keyboard.Controls.OfType<Key>())
            //    {
            //        if (this.Keyboard.keyPressed == k.Text)
            //        {
            //            k.clickButton();
            //            k.Enabled = false;

            //        }
            //    }
            //}

            //this.label1.Text += this.Keyboard.keyPressed;

        }

        private void picNewGame_Click(object sender, EventArgs e)
        {
            this.newGame();
        }

        private void picNewGame_MouseEnter(object sender, EventArgs e)
        {
            this.picNewGame.Image = global::GuessPakGanern.Properties.Resources.newgame_selected;
        }

        private void picNewGame_MouseLeave(object sender, EventArgs e)
        {
            this.picNewGame.Image = global::GuessPakGanern.Properties.Resources.newgame;
        }

        private void Completed_Popup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((sender as Popup).Result == 1)
            {
                this.endGame();
            }
            else
            {
                this.newRound();
            }
        }
        
        #endregion

    }
}
