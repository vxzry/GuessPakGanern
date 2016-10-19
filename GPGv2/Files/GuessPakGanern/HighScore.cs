namespace GuessPakGanern
{
    public class HighScore
    {
        private int score;
        private string player;

        public int Score { get { return this.score; } set { this.score = value; } }
        public string Player { get { return this.player; } set { this.player = value; } }

        public HighScore()
        {
            this.score = 0;
            this.player = "";
        }

        public HighScore(string player, int score)
        {
            this.Player = player;
            this.Score = score;
        }
    }
}
