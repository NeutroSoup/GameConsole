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
        byte playerCount;
        byte mapX = 15;
        byte mapY = 15;
        byte appleX;
        byte appleY;
        short snakeLength;
        List<int> snakeX = new List<int>();
        List<int> snakeY = new List<int>();
        byte moveAngle;
        bool arYraOb;
        Random rnd;
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

        }
        private void ControlsTimer_Tick(object sender, KeyEventArgs e)
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
        public void SnakeSpawn()
        {
            snakeLength = 1;
            moveAngle = 1;
            arYraOb = false;
            snakeX.Add(mapX / 2);
            snakeY.Add(mapY - 1);

            snakeX.Add(snakeX[0]);
            snakeY.Add(snakeY[0] + 1);

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
        public void DrawMap()
        {
            string path = @"C:\Users\Vilius\Desktop\Snake Sprites";
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
                    if (x == 0 || y == 0 || x == mapX + 1 || y == mapY + 1)
                    {
                        var border = new PictureBox
                        {
                            BackColor = Color.Brown,
                            Size = new Size(50, 50),
                            Location = new Point(x * 50, y * 50),
                        };
                        this.Controls.Add(border);
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
                    else if (y == appleY && x == appleX && arYraOb == true)
                    {
                        var HeadUp = new PictureBox
                        {
                            BackColor = Color.Red,
                            Size = new Size(50, 50),
                            Location = new Point(x * 50, y * 50),
                            //Image = Image.FromFile($@"{path}\apple.png"),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                        };
                        this.Controls.Add(HeadUp);
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
                    else
                    {
                        PictureBox Background = new PictureBox
                        {
                            BackColor = Color.LawnGreen,
                            Size = new Size(50, 50),
                            Location = new Point(x * 50, y * 50),
                        };
                        this.Controls.Add(Background);
                    }
                }
            }
        }
        public bool Death()
        {
            bool result = false;
            if (snakeX[0] <= 0 || snakeX[0] > mapX || snakeY[0] <= 0 || snakeY[0] > mapY)
            {
                result = true;
            }
            for (int i = 1; i <= snakeLength; i++)
            {
                if (snakeX[0] == snakeX[i] && snakeY[0] == snakeY[i])
                {
                    result = true;
                }
            }
            return result;
        }
        public void Lose()
        {
            MessageBox.Show($"You lost! Your score: {snakeLength}");
            Application.Exit();
        }
    }
}
