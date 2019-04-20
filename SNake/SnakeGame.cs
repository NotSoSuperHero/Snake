using System;
using System.Drawing;
using System.Windows.Forms;

namespace SNake
{
    public partial class SnakeGame : Form
    {
        private int direction = 0;
        private int score = 0;
        private Timer gameLoop = new Timer();
        private Random rand = new Random();
        private Snake snake;
        private Food food;
        private Food Special;
        private int Cooldown = 0;
        private bool SpecialExists = false;
        int Speed = 100;
        private int LoopDirection; //Kintamasis saugo gyvatės kryptį intervalo pradžioje.


        public SnakeGame()
        {
            InitializeComponent();
            snake = new Snake();
            snake.Grow();
            snake.Grow();
            snake.Grow();
            food = new Food(rand);
            gameLoop.Interval = Speed;
            gameLoop.Tick += Update;
        }

        private void SnakeGame_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (MenuLabel.Visible)
                    {
                        MenuLabel.Visible = false;
                        gameLoop.Start();
                    }
                    break;
                case Keys.Space:
                    if (!MenuLabel.Visible)
                        gameLoop.Enabled = (gameLoop.Enabled) ? false : true;
                    break;
                /**Lango dydžio testavimas
                      **/
                case Keys.A:
                    MenuLabel.Text = String.Format("Width is {0}, Heigth is {1}", ClientSize.Width, ClientSize.Height);
                    break;


            }
            if (gameLoop.Enabled)
            {
                switch (e.KeyData)
                {

                    //Vietoje tikrinimo su dabartine kryptimi, tikriname su intervalo kryptimi.
                    case Keys.Right:
                        if (LoopDirection != 2)
                            direction = 0;
                        break;
                    case Keys.Down:
                        if (LoopDirection != 3)
                            direction = 1;
                        break;
                    case Keys.Left:
                        if (LoopDirection != 0)
                            direction = 2;
                        break;
                    case Keys.Up:
                        if (LoopDirection != 1)
                            direction = 3;
                        break;
                }
            }
        }

        private void Update(object sender, EventArgs e)
        {
            this.Text = string.Format("Snake - Score: {0}", score);
            LoopDirection = direction; //Intervalo pradžioje nurodome to ciklo kryptį
            snake.Move(direction);
            for (int i = 1; i < snake.Body.Length; i++)
                if (snake.Body[0].IntersectsWith(snake.Body[i]))
                    Restart();
            if (snake.Body[0].X < 1)
                snake.Body[0].X = 391;
            if (snake.Body[0].X > 391)
                snake.Body[0].X = 1;
            if (snake.Body[0].Y < 1)
                snake.Body[0].Y = 391;
            if (snake.Body[0].Y > 391)
                snake.Body[0].Y = 1;
            if (snake.Body[0].IntersectsWith(food.Piece))
            {
                score += Food.GetScore();
                snake.Grow();
                food.Generate(rand);
                if (Cooldown == 0)
                {
                    if (!SpecialExists)
                    {
                        Special = new Food(rand, 2);
                        SpecialExists = true;
                    }
                }
                else
                    Cooldown--;
            }
            if (Special != null)
            if (snake.Body[0].IntersectsWith(Special.Piece))
            {
                Special = null;
                SpecialExists = false;
                Cooldown = 10;
                score += 100;
            }
            this.Invalidate();
        }

        private void Restart()
        {
            gameLoop.Stop();
            Cooldown = 5;
            SpecialExists = false;
            snake = new Snake();
            snake.Grow();
            snake.Grow();
            snake.Grow();
            food = new Food(rand);
            direction = 0; score = 1;
            MenuLabel.Visible = true;
        }

        private void SnakeGame_Paint(object sender, PaintEventArgs e)
        { 
            snake.Draw(e.Graphics);
            food.Draw(e.Graphics);
            if (SpecialExists)
                Special.Draw(e.Graphics);

        }
    }
}

