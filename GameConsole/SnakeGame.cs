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
        short snakeLength;
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
            GameTimer.Interval = 200;
            SnakeSpawn();
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!Death())
            {
                AppleSpawn();
                SnakeMove();
                SnakeEat();
                DrawMap();
            }
            else { GameTimer.Enabled = false; }
        }
        public void SnakeMove()
        {
            if (moveAngle == 1) //virsus
            {
                SnakeBody[0].x = SnakeBody[0].x;
                SnakeBody[0].y = SnakeBody[0].y - 1;
            }
            if (moveAngle == 2)//desine
            {
                SnakeBody[0].x = SnakeBody[0].x + 1;
                SnakeBody[0].y = SnakeBody[0].y;
            }
            if (moveAngle == 3)//apacia
            {
                SnakeBody[0].x = SnakeBody[0].x;
                SnakeBody[0].y = SnakeBody[0].y + 1;
            }
            if (moveAngle == 4)//kaire
            {
                SnakeBody[0].x = SnakeBody[0].x - 1;
                SnakeBody[0].y = SnakeBody[0].y;
            }
            for (int i = snakeLength; i >= 0; i--)
            {
                SnakeBody[i].x = SnakeBody[i-1].x;
                SnakeBody[i].y = SnakeBody[i-1].y;
            }
        }
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)//fixed
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
        private void AppleSpawn()//fixed
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
        private void SnakeEat()//fixed
        {
            if (SnakeBody[0].x == appleX && SnakeBody[0].y == appleY)
            {
                SnakeBody.Add(new SnakeCell(SnakeBody[snakeLength].x, SnakeBody[snakeLength].x, snakeLength));
                snakeLength++;
                isAppleOnMap = false;
            }
        }
        private void SnakeSpawn()//fixed
        {
            snakeLength = 1;
            moveAngle = 1;
            isAppleOnMap = false;
            SnakeBody.Add(new SnakeCell(mapX / 2, mapY - 1, 0));
            SnakeBody.Add(new SnakeCell(SnakeBody[0].x, SnakeBody[0].y + 1, 1));

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
        private bool Death()//fixed
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
        private void Lose()//fixed
        {
            MessageBox.Show($"You lost! Your score: {snakeLength}");
            Application.Exit();
        }
        private void DrawMap()//reuse and delete
        {

            for (int y = 0; y <= mapY + 1; y++)
            {
                for (int x = 0; x <= mapX + 1; x++)
                {
                    bool arYraSnk = false;
                    for (int i = 1; i <= snakeLength; i++)
                    {
                        if (y == snakeY[i] && x == snakeX[i])
                        {
                            arYraSnk = true;
                            break;
                        }
                        else
                        {
                            arYraSnk = false;
                        }
                    }
                    else if (arYraSnk)
                    {
                        var Body = new PictureBox
                        {
                            BackColor = Color.Green,
                            Size = new Size(50, 50),
                            Location = new Point(x * 50, y * 50),
                            //Image = Image.FromFile($@"{path}\apple.png"),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };
                        this.Controls.Add(Body);
                    }
                    else if (y == snakeY[0] && x == snakeX[0])
                    {
                        switch (moveAngle)
                        {
                            case 1:
                                var HeadUp = new PictureBox
                                {
                                    BackColor = Color.DarkGreen,
                                    Size = new Size(50, 50),
                                    Location = new Point(x * 50, y * 50),
                                    //Image = Image.FromFile($@"{path}\Thead.png"),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                };
                                this.Controls.Add(HeadUp);
                                break;
                            case 2:
                                var HeadRight = new PictureBox
                                {
                                    BackColor = Color.DarkGreen,
                                    Size = new Size(50, 50),
                                    Location = new Point(x * 50, y * 50),
                                    //Image = Image.FromFile($@"{path}\Rhead.png"),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                };
                                this.Controls.Add(HeadRight);
                                break;
                            case 3:
                                var HeadDown = new PictureBox
                                {
                                    BackColor = Color.DarkGreen,
                                    Size = new Size(50, 50),
                                    Location = new Point(x * 50, y * 50),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    //Image = Image.FromFile($@"{path}\Bhead.png"),
                                };
                                this.Controls.Add(HeadDown);
                                break;
                            case 4:
                                var HeadLeft = new PictureBox
                                {
                                    BackColor = Color.DarkGreen,
                                    Size = new Size(50, 50),
                                    Location = new Point(x * 50, y * 50),
                                    //Image = Image.FromFile($@"{path}\Lhead.png"),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                };
                                this.Controls.Add(HeadLeft);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
