using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class normalLevel : Form
    {
        private int rI, rJ;
        private PictureBox fruit;
        private PictureBox[] snake = new PictureBox[400];
        private Label labelScore;
        private int dirX, dirY;
        private int width = 900;
        private int height = 800;
        private int sizeOfCube = 32;
        private int score = 0;
        public normalLevel()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Joistick);
            dirX = 1;
            dirY = 0;
            labelScore = new Label();
            labelScore.Text = "Score: 0";
            labelScore.Location = new Point(900, 100);
            this.Controls.Add(labelScore);
            snake[0] = new PictureBox();
            snake[0].BackColor = Color.Green;
            snake[0].Size = new Size(sizeOfCube, sizeOfCube);
            snake[0].Location = new Point(320, 320);
            this.Controls.Add(snake[0]);
            fruit = new PictureBox();
            fruit.BackColor = Color.Orange;
            fruit.Size = new Size(sizeOfCube, sizeOfCube);
            generateFruit();
            GenerateMap();
            timer1.Tick += new EventHandler(update);
            timer1.Interval = 300;
            timer1.Start();
            
            
        }
        private void eatingVoid()
        {
            if (snake[0].Location.X == rI && snake[0].Location.Y == rJ)
            {
                score++;
                labelScore.Text = "Score: " + score;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X - sizeOfCube * dirX, snake[score].Location.Y + sizeOfCube * dirY);
                snake[score].Size = new Size(sizeOfCube, sizeOfCube);
                snake[score].BackColor = Color.Green;
                this.Controls.Add(snake[score]);
                generateFruit();

            }
            
        }
        private void checkBorder()
        {
            if (snake[0].Location.X < 63)
            {
                for (int i = 1; i <= score; i++)
                    this.Controls.Remove(snake[i]);
                score = 0;
                labelScore.Text = "Score: " + score;
                dirX = 1;
                Close();
            }
            if (snake[0].Location.X > height - sizeOfCube)
            {
                for (int i = 1; i <= score; i++)
                    this.Controls.Remove(snake[i]);
                score = 0;
                labelScore.Text = "Score: " + score;
                dirX = -1;
                Close();
            }
            if (snake[0].Location.Y < 63)
            {
                for (int i = 1; i <= score; i++)
                    this.Controls.Remove(snake[i]);
                score = 0;
                labelScore.Text = "Score: " + score;
                dirY = 1;
                Close();
            }
            if (snake[0].Location.Y > height - sizeOfCube)
            {
                for (int i = 1; i <= score; i++)
                    this.Controls.Remove(snake[i]);
                score = 0;
                labelScore.Text = "Score: " + score;
                dirY = -1;
                Close();
            }
        }
        private void eatItself()
        {
            for (int i = 1; i < score; i++)
            {
                if (snake[0].Location == snake[i].Location)
                {
                    for (int j = i; j <= score; j++)
                    {
                        this.Controls.Remove(snake[j]);
                    }
                    score = score - (score - i + 1);
                }
            }
        }
        
        private void generateFruit()
        {
            Random r = new Random();
            rI = r.Next(32, height - sizeOfCube);
            int tempI = rI % sizeOfCube;
            rI -= tempI;
            rJ = r.Next(32, height - sizeOfCube);
            int tempJ = rJ % sizeOfCube;
            rJ -= tempJ;
            fruit.Location = new Point(rI, rJ);

            this.Controls.Add(fruit);
        }
        private void GenerateMap()
        {
            for (int i = 0; i <= width / sizeOfCube; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(32, sizeOfCube * i);
                pic.Size = new Size(width - 100, 1);
                this.Controls.Add(pic);
            }
            for (int i = 0; i <= (height / sizeOfCube) + 1; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(sizeOfCube * i, 32);
                pic.Size = new Size(1, height);
                this.Controls.Add(pic);
            }
        }
        private void moveSnake()
        {
            for (int i = score; i >= 1; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }
            snake[0].Location = new Point(snake[0].Location.X + dirX * sizeOfCube, snake[0].Location.Y + dirY * sizeOfCube);
            if (score > 10)
                timer1.Interval = 250;
            if (score > 20)
                timer1.Interval = 200;
            eatItself();
        }
        private void update(Object myObject, EventArgs eventsArgs)
        {
            checkBorder();
            eatingVoid();
            moveSnake();
        }

        private void Joistick(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "Up":
                    dirY = -1;
                    dirX = 0;
                    break;
                case "Down":
                    dirY = 1;
                    dirX = 0;
                    break;
            }
        }

        private void normalLevel_Load(object sender, EventArgs e)
        {

        }
    }
}
