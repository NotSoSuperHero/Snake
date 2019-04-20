using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SNake
{
    public class Food
    {
        public Rectangle Piece;
        private int x, y;
        private const int width = 10, heigth = 10;
        public Food(Random rand, Snake snake)
        {
            Generate(rand, snake);
            Piece = new Rectangle(x, y, width, heigth);
        }

        public void Draw(Graphics graphics)
        {
            Piece.X = x;
            Piece.Y = y;
            graphics.FillRectangle(Brushes.Brown, Piece);
        }
        public void Generate(Random rand, Snake snake)
        {
            //Sukuriam hashseta kad atrinktu visus unikalius
            var excludeX = new HashSet<int>() { x };
            var excludeY = new HashSet<int>() { y };
            //pridedam dabartine padeti maisto 
            //pridedam gyvateles padeti
            var forbinned = snake.GetBodyList().Select(xx => new { X = xx.X, Y = xx.Y });
            foreach(var XY in forbinned)
            {
                 excludeX.Add(XY.X);
                 excludeY.Add(XY.Y);
            }

            //nesugalvojau kaip graziau aprasyt :D
            var range = new List<int>() { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210, 220, 230, 240, 250, 260, 270, 280, 290, 300, 310, 320, 330, 340, 350, 360, 370, 380, 390 };
            
            //isrenkam range nuo 0 iki 400 taskus kurie nesikerta su gyvate ar maisto esama padetim
            var rangeX = range.Where(i => !excludeX.Contains(i));
            var rangeY = range.Where(i => !excludeY.Contains(i));
            //randomizinam po viena taska is abieju masyvu ir priskiriam ju reiksmes
            int indexX = rand.Next(0, 40 - excludeX.Count);
            int indexY = rand.Next(0, 40 - excludeY.Count);
            x = rangeX.ElementAt(indexX);
            y = rangeY.ElementAt(indexY);

            /*x = rand.Next(0, 40) * 10;
            y = rand.Next(0, 40) * 10;*/
        }
    }
}
