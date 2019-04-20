using System;
using System.Drawing;

namespace SNake
{
    public class Food
    {
        public Rectangle Piece;
        private int x, y;
        private const int width = 10, heigth = 10;
        private static int ScoreChance;
        public static int Score;
        private Brush Color = Brushes.Green;

        public Food(Random rand)
        {
            Generate(rand);
            Piece = new Rectangle(x, y, width, heigth);
        }

        public void Draw(Graphics graphics)
        {
            Piece.X = x;
            Piece.Y = y;
            graphics.FillRectangle(Color, Piece);
        }
        public void Generate(Random rand)
        {
            x = rand.Next(0, 40) * 10;
            y = rand.Next(0, 40) * 10;
            ScoreChance = GenerateScoreChance(rand);
            Score = GenerateScore(ScoreChance);
        }
        public int GenerateScoreChance (Random rand)
        {
            return rand.Next(1, 100);
        }
        public int GenerateScore(int ScoreChance)
        {
            if (ScoreChance <= 55)
            {
                Color = Brushes.Green;
                return 1;
            }
            if (ScoreChance > 85)
            {
                Color = Brushes.Red;
                return 10;
            }
            else
            {
                Color = Brushes.Yellow;
                return 5;
            }
        }
        public static int GetScore() { return Score; }
        public int GetChance() { return ScoreChance; }
    }
}
