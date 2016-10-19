namespace GuessPakGanern
{
    public class HighScore
    {
        private int score;
        private string player;

        public HighScore()
        {
            this.Score = 0;
            this.Player = "";
        }

        public HighScore(string player, int score)
        {
            this.Player = player;
            this.Score = score;
        }

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
    }
}
