using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

namespace SNake
{
    public class Snake
    {
        public Rectangle[] Body;
        //Sumazintas bloko dydis suteikia gyvatelei pilnai nesujungtu bloku ivaizdi
        private int x = 31, y = 31;
        const int width = 8, heigth = 8;
        public int Heigth {  get { return heigth; } set { } }
        public int Width { get { return width;  } set { } }
        public Snake()
        {
            Body = new Rectangle[1];
            Body[0] = new Rectangle(x, y, width, heigth);
            
        }

        public void Draw()
        {
            for (int i = Body.Length - 1; i > 0; i--)
                Body[i] = Body[i - 1];
        }

        public List<Rectangle> GetBodyList()
        {
            return Body.ToList();
        }
        public void Draw(Graphics graphics, Brush HeadColor)
        {
            graphics.FillRectangles(Brushes.Black, Body);
            graphics.FillRectangle(HeadColor, Body[0]);
        }

        public void Move(int direction) // 0 = Right, 1 = Down;, 2 = Left, 3 = Up
        {
            Draw();
            switch (direction)
            {
                case 0:
                    Body[0].X += 10;
                    break;
                case 1:
                    Body[0].Y += 10;
                    break;
                case 2:
                    Body[0].X -= 10;
                    break;
                case 3:
                    Body[0].Y -= 10;
                    break;
            }
        }

        public void Grow()
        {
            List<Rectangle> temp = Body.ToList();
            temp.Add(new Rectangle(Body[Body.Length - 1].X, Body[Body.Length - 1].Y, width, heigth));
            Body = temp.ToArray();
        }
    }   
}
