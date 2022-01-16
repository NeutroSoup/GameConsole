using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
namespace GameConsole
{
    public partial class SnakeGame : Form
    {
        byte mapX = 15;
        byte mapY = 15;
        byte appleX;
        byte appleY;
        int snakeLength;
        List<SnakeCell> SnakeBody = new List<SnakeCell>();
        byte moveAngle;
        bool isAppleOnMap;
        Random rnd;

        string path = @"C:\Users\Vilius\Desktop\Snake Sprites";
        public SnakeGame()
        {
            InitializeComponent();
        }

        private void SnakeGame_Load(object sender, EventArgs e)
        {
            GameTimer.Enabled = true;
            GameTimer.Interval = 2000;
            SnakeSpawn();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //if (!Death())
            //{
                AppleSpawn();
                SnakeMove();
                SnakeEat();
                this.Controls.Clear();
                DrawSnake();
           // }
            //else
            //{
               // GameTimer.Enabled = false;
               // Lose();
            //}
        }
        public void SnakeMove()
        {
            if (moveAngle == 1) //up
            {
                SnakeBody[0].x = SnakeBody[0].x;
                SnakeBody[0].y = SnakeBody[0].y - 1;
            }
            if (moveAngle == 2)//right
            {
                SnakeBody[0].x = SnakeBody[0].x + 1;
                SnakeBody[0].y = SnakeBody[0].y;
            }
            if (moveAngle == 3)//down
            {
                SnakeBody[0].x = SnakeBody[0].x;
                SnakeBody[0].y = SnakeBody[0].y + 1;
            }
            if (moveAngle == 4)//left
            {
                SnakeBody[0].x = SnakeBody[0].x - 1;
                SnakeBody[0].y = SnakeBody[0].y;
            }
            for (int i = snakeLength; i >= 1; i--)
            {
                SnakeBody[i].x = SnakeBody[i - 1].x;
                SnakeBody[i].y = SnakeBody[i - 1].y;
            }
        }
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            bool canMove = true;
            while (!Death())
            {
                if (canMove)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.W:
                            if (moveAngle != 3)
                            {
                                moveAngle = 1;
                                canMove = false;
                            }
                            break;
                        case Keys.S:
                            if (moveAngle != 1)
                            {
                                moveAngle = 3;
                                canMove = false;
                            }
                            break;
                        case Keys.A:
                            if (moveAngle != 2)
                            {
                                moveAngle = 4;
                                canMove = false;
                            }
                            break;
                        case Keys.D:
                            if (moveAngle != 4)
                            {
                                moveAngle = 2;
                                canMove = false;
                            }
                            break;
                        default:
                            break;
                    }
                }
                canMove = true;
            }
        }
        private void AppleSpawn()
        {
            if (isAppleOnMap == false)
            {
                rnd = new Random();
                appleX = (byte)rnd.Next(1, mapX);
                appleY = (byte)rnd.Next(1, mapY);
                bool isTaken = true;
                while (isTaken)
                {
                    for (int i = 0; i <= snakeLength; i++)
                    {
                        if (appleX == SnakeBody[i].x && appleY == SnakeBody[i].y)
                        {
                            appleX = (byte)rnd.Next(1, mapX);
                            appleY = (byte)rnd.Next(1, mapY);
                            isTaken = true;
                            break;
                        }
                        else
                        {
                            var Apple = new PictureBox
                            {
                                Size = new Size(50, 50),
                                Location = new Point(appleX * 50, appleY * 50),
                                Image = Image.FromFile($@"{path}\apple.png"),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                            };
                            this.Controls.Add(Apple);
                            isAppleOnMap = true;
                            isTaken = false;
                        }
                    }
                }
            }
        }
        private void SnakeEat()
        {
            if (SnakeBody[0].x == appleX && SnakeBody[0].y == appleY)
            {
                SnakeBody.Add(new SnakeCell(SnakeBody[snakeLength].x, SnakeBody[snakeLength].x));
                snakeLength++;
                isAppleOnMap = false;
            }
        }
        private void SnakeSpawn()
        {
            snakeLength = 2;
            moveAngle = 1;
            isAppleOnMap = false;
            SnakeBody.Add(new SnakeCell(mapX / 2, mapY - 3));
            SnakeBody.Add(new SnakeCell(mapX / 2, mapY - 2));
            SnakeBody.Add(new SnakeCell(mapX / 2, mapY - 1));
            for (int y = 0; y <= mapY + 1; y++)
            {
                for (int x = 0; x <= mapX + 1; x++)
                {
                    if (x == 0 || y == 0 || x == mapX + 1 || y == mapY + 1)
                    {
                        var border = new PictureBox
                        {
                            BackColor = Color.YellowGreen,
                            Size = new Size(50, 50),
                            Location = new Point(x * 50, y * 50),
                        };
                        this.Controls.Add(border);
                    }
                    else
                    {
                        PictureBox Background = new PictureBox
                        {
                            BackColor = Color.Yellow,
                            Size = new Size(50, 50),
                            Location = new Point(x * 50, y * 50),
                        };
                        this.Controls.Add(Background);
                    }
                }
            }
        }
        private bool Death()
        {
            bool result = false;
            if (SnakeBody[0].x <= 0 || SnakeBody[0].x > mapX || SnakeBody[0].y <= 0 || SnakeBody[0].y > mapY)
            {
                result = true;
            }
            for (int i = 1; i <= snakeLength; i++)
            {
                if (SnakeBody[0].x == SnakeBody[i].x && SnakeBody[0].y == SnakeBody[i].y)
                {
                    result = true;
                }
            }
            return result;
        }
        private void Lose()
        {
            MessageBox.Show($"You lost! Your score: {snakeLength}");
            Application.Exit();
        }
        private void DrawSnake()
        {
            if (moveAngle == 1) //up
            {
                var HeadUp = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(SnakeBody[0].x * 50, SnakeBody[0].y * 50),
                    Image = Image.FromFile($@"{path}\headUp.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(HeadUp);
            }
            else if (moveAngle == 2)//right
            {
                var HeadRight = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(SnakeBody[0].x * 50, SnakeBody[0].y * 50),
                    Image = Image.FromFile($@"{path}\headRight.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(HeadRight);
            }
            else if (moveAngle == 3)//down
            {
                var HeadDown = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(SnakeBody[0].x * 50, SnakeBody[0].y * 50),
                    Image = Image.FromFile($@"{path}\headDown.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(HeadDown);
            }
            else if (moveAngle == 4)//left
            {
                var HeadLeft = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(SnakeBody[0].x * 50, SnakeBody[0].y * 50),
                    Image = Image.FromFile($@"{path}\headLeft.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(HeadLeft);
            }
            for (int i = 1; i < snakeLength; i++)
            {
                //checks if nearby cell is occupied
                bool upCell = ((SnakeBody[i].x == SnakeBody[i - 1].x) && (SnakeBody[i].y + 1 == SnakeBody[i - 1].y)) || ((SnakeBody[i].x == SnakeBody[i + 1].x) && (SnakeBody[i].y + 1 == SnakeBody[i + 1].y));
                bool downCell = ((SnakeBody[i].x == SnakeBody[i - 1].x) && (SnakeBody[i].y - 1 == SnakeBody[i - 1].y)) || ((SnakeBody[i].x == SnakeBody[i + 1].x) && (SnakeBody[i].y - 1 == SnakeBody[i + 1].y));
                bool leftCell = ((SnakeBody[i].x - 1 == SnakeBody[i - 1].x) && (SnakeBody[i].y == SnakeBody[i - 1].y)) || ((SnakeBody[i].x - 1 == SnakeBody[i + 1].x) && (SnakeBody[i].y == SnakeBody[i + 1].y));
                bool rightCell = ((SnakeBody[i].x + 1 == SnakeBody[i - 1].x) && (SnakeBody[i].y == SnakeBody[i - 1].y)) || ((SnakeBody[i].x + 1 == SnakeBody[i + 1].x) && (SnakeBody[i].y == SnakeBody[i + 1].y));

                    //horizontal sprite
                    if (rightCell && leftCell)
                    {
                        var Horizontal = new PictureBox
                        {
                            Size = new Size(50, 50),
                            Location = new Point(SnakeBody[i].x * 50, SnakeBody[i].y * 50),
                            Image = Image.FromFile($@"{path}\horizontal.png"),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };
                        this.Controls.Add(Horizontal);
                    }
                    //vertical sprite
                    else if (upCell && downCell)
                    {
                        var Vertical = new PictureBox
                        {
                            Size = new Size(50, 50),
                            Location = new Point(SnakeBody[i].x * 50, SnakeBody[i].y * 50),
                            Image = Image.FromFile($@"{path}\vertical.png"),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };
                        this.Controls.Add(Vertical);
                    }
                    //up left sprite
                    else if (upCell && leftCell)
                    {
                        var turnUpLeft = new PictureBox
                        {
                            Size = new Size(50, 50),
                            Location = new Point(SnakeBody[i].x * 50, SnakeBody[i].y * 50),
                            Image = Image.FromFile($@"{path}\turnUpLeft.png"),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };
                        this.Controls.Add(turnUpLeft);
                    }
                    //up right sprite
                    else if (upCell && rightCell)
                    {
                        var turnUpRight = new PictureBox
                        {
                            Size = new Size(50, 50),
                            Location = new Point(SnakeBody[i].x * 50, SnakeBody[i].y * 50),
                            Image = Image.FromFile($@"{path}\turnUpRight.png"),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };
                        this.Controls.Add(turnUpRight);
                    }
                    //down left sprite
                    else if (downCell && leftCell)
                    {
                        var turnDownLeft = new PictureBox
                        {
                            Size = new Size(50, 50),
                            Location = new Point(SnakeBody[i].x * 50, SnakeBody[i].y * 50),
                            Image = Image.FromFile($@"{path}\turnDownLeft.png"),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };
                        this.Controls.Add(turnDownLeft);
                    }
                    //down right sprite
            }
            int sl = snakeLength;
            bool upTail = ((SnakeBody[sl].x == SnakeBody[sl - 1].x) && (SnakeBody[sl].y + 1 == SnakeBody[sl - 1].y));
            bool downTail = ((SnakeBody[sl].x == SnakeBody[sl - 1].x) && (SnakeBody[sl].y - 1 == SnakeBody[sl - 1].y));
            bool leftTail = ((SnakeBody[sl].x - 1 == SnakeBody[sl - 1].x) && (SnakeBody[sl].y == SnakeBody[sl - 1].y));
            bool rightTail = ((SnakeBody[sl].x + 1 == SnakeBody[sl - 1].x) && (SnakeBody[sl].y == SnakeBody[sl - 1].y));
            if (upTail)
            {
                var tailUp = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(SnakeBody[sl].x * 50, SnakeBody[sl].y * 50),
                    Image = Image.FromFile($@"{path}\tailUp.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(tailUp);
            }
            else if (downTail)
            {
                var tailDown = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(SnakeBody[sl].x * 50, SnakeBody[sl].y * 50),
                    Image = Image.FromFile($@"{path}\tailDown.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(tailDown);
            }
            else if (leftTail)
            {
                var tailLeft = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(SnakeBody[sl].x * 50, SnakeBody[sl].y * 50),
                    Image = Image.FromFile($@"{path}\tailLeft.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(tailLeft);
            }
            else if (rightTail)
            {
                var tailRight = new PictureBox
                {
                    Size = new Size(50, 50),
                    Location = new Point(SnakeBody[sl].x * 50, SnakeBody[sl].y * 50),
                    Image = Image.FromFile($@"{path}\tailRight.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                this.Controls.Add(tailRight);
            }
        }
    }
}
