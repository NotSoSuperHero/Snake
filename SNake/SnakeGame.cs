using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        private int Cooldown = 5;
        private bool SpecialExists = false;
        int Speed = 65;
        private int LoopDirection; //Kintamasis saugo gyvatės kryptį intervalo pradžioje.
        private Brush SnakeHeadColor = Brushes.Black;
        private Brush SpecFoodColor = Brushes.Coral;
        private Color BackgroundColor;
        private string PlayerName = "";
        private int Length = 3;

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
            FillLeaderboard();
        }
        private async void SpeedUp()
        {
            int temp = Speed;
            Speed = Speed / 2;
            await Task.Delay(7000);
            Speed = temp;
        }
        private void SnakeGame_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyData)
            {
                case Keys.Space:
                    if (!Start.Visible)
                        gameLoop.Enabled = (gameLoop.Enabled) ? false : true;
                    CloseButton.Enabled = (CloseButton.Enabled) ? false : true;
                    CloseButton.Visible = (CloseButton.Visible) ? false : true;
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
            gameLoop.Interval = Speed;
            this.Text = string.Format("Snake - Score: {0}, Current snake length: {1}", score, Length);
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
                Length++;
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
                    SpeedUp();
                }
            this.Invalidate();
        }

        private void Restart()
        {
            Mode(true);
            gameLoop.Stop();
            Cooldown = 5;
            SpecialExists = false;
            snake = new Snake();
            snake.Grow();
            snake.Grow();
            snake.Grow();
            food = new Food(rand);
            WriteLeaderboard();
            FillLeaderboard();
            direction = 0; score = 0; Length = 3;
            this.BackColor = SystemColors.Control;
            Namebox.Text = PlayerName;
           
        }

        private void SnakeGame_Paint(object sender, PaintEventArgs e)
        {
            snake.Draw(e.Graphics, SnakeHeadColor);
            food.Draw(e.Graphics);
            if (SpecialExists)
                Special.Draw(e.Graphics, SpecFoodColor);
        }


        private void Start_Click(object sender, EventArgs e)
        {
            PlayerName = Namebox.Text;
            if (Namebox.Text == null)
            {
                PlayerName = "";
            }
            Mode(false);
            
            if (BackgroundColor == null)
                this.BackColor = SystemColors.Control;
            else this.BackColor = BackgroundColor;
            gameLoop.Start();
        }

        private void HeadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (HeadBox.Text)
            {
                case "Black":
                    SnakeHeadColor = Brushes.Black;
                    break;
                case "Yellow":
                    SnakeHeadColor = Brushes.Yellow;
                    break;
                case "Red":
                    SnakeHeadColor = Brushes.Red;
                    break;
            }
        }
        private void Mode(bool mode)
        {
            MenuLabel.Visible = mode;
            HeadBox.Enabled = mode;
            HeadBox.Visible = mode;
            Label1.Visible = mode;
            Start.Enabled = mode;
            Start.Visible = mode;
            Label2.Visible = mode;
            Namebox.Visible = mode;
            Namebox.Enabled = mode;
            Label3.Visible = mode;
            SpecFoodBox.Enabled = mode;
            SpecFoodBox.Visible = mode;
            Label4.Visible = mode;
            BackgroundBox.Enabled = mode;
            BackgroundBox.Visible = mode;
            Label5.Visible = mode;
            SpeedBox.Enabled = mode;
            SpeedBox.Visible = mode;
            Leaderboard.Enabled = mode;
            Leaderboard.Visible = mode;
            CloseButton.Enabled = mode;
            CloseButton.Visible = mode;
        }

        private void SpecFoodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SpecFoodBox.Text)
            {
                case "Bronze":
                    SpecFoodColor = Brushes.Coral;
                    break;
                case "Silver":
                    SpecFoodColor = Brushes.Silver;
                    break;
                case "Gold":
                    SpecFoodColor = Brushes.Gold;
                    break;
            }
        }

        private void BackgroundBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BackgroundBox.Text)
            {
                case "White":
                    BackgroundColor = Color.FromArgb(255, 255, 255);
                    break;
                case "Grey":
                    BackgroundColor = Color.FromArgb(192, 192, 192);
                    break;
                case "Light blue":
                    BackgroundColor = Color.FromArgb(153, 255, 255);
                    break;
            }
        }

        private void SpeedBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SpeedBox.Text)
            {
                case "Slow":
                    Speed = 80;
                    break;
                case "Medium":
                    Speed = 65;
                    break;
                case "Fast":
                    Speed = 50;
                    break;
            }
        }
        private void WriteLeaderboard()
        {
            StreamWriter writer = new StreamWriter("./Leaderboard.txt", true);
            writer.WriteLine("Player: {0,-20} : Score: {1}", PlayerName, score);
            writer.Close();
        }

        private void FillLeaderboard()
        {
            List<Result> result = new List<Result>();
            Leaderboard.Rows.Clear();
            using (StreamReader reader = new StreamReader("./Leaderboard.txt"))
            {
                int nr = Leaderboard.Rows.Count;
                if (new FileInfo("../../Leaderboard.txt").Length != 0)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] parts = line.Split(':');
                        result.Add(new Result(parts[1], int.Parse(parts[3])));
                        line = reader.ReadLine();
                    }
                }
            }
            result.Sort();
            result.Reverse();
            if (result.Count > 10)
            {
                while (result.Count > 10)
                {
                    result.RemoveAt(10);
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                Leaderboard.Rows.Add(i + 1, result[i].Name, result[i].score);
            }
            
            
        }

        private void Close_Click(object sender, EventArgs e)
        {
            WriteLeaderboard();
            this.Close();
        }
    }
 }

