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
using System.Threading;
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
        string moveAngle;
        bool isAppleOnMap;
        bool canMove = true;
        Random rnd;

        Bitmap Arena;
        Graphics g;
        public int gameSpeed { get; set; }
        public SnakeGame(int GameSpeed)
        {
            InitializeComponent();
            this.gameSpeed = GameSpeed;
        }

        private void SnakeGame_Load(object sender, EventArgs e)
        {
            GameTimer.Enabled = true;
            GameTimer.Interval = gameSpeed;
            SnakeSpawn();
            Arena = new Bitmap(PbArena.Width, PbArena.Height);
            g = Graphics.FromImage(Arena);
            PbArena.Image = Arena;
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!Death())
            {
                canMove = true;
                g.Clear(Color.White);
                SnakeMove();
                DrawBackground();
                DrawSnake();
                SnakeEat();
                Apple();
                PbArena.Image = Arena;
            }
            else
            {
                GameTimer.Enabled = false;
                Lose();
            }
        }
        public void SnakeMove()
        {
            if (moveAngle == "up")
            {
                SnakeBody[0].x = SnakeBody[0].x;
                SnakeBody[0].y = SnakeBody[0].y - 1;
            }
            if (moveAngle == "right")
            {
                SnakeBody[0].x = SnakeBody[0].x + 1;
                SnakeBody[0].y = SnakeBody[0].y;
            }
            if (moveAngle == "down")
            {
                SnakeBody[0].x = SnakeBody[0].x;
                SnakeBody[0].y = SnakeBody[0].y + 1;
            }
            if (moveAngle == "left")
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
        private void SnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (canMove)
            {
                Keys key = e.KeyCode;
                if (key == Keys.W && moveAngle != "down")
                {
                    moveAngle = "up";
                    canMove = false;
                }
                if (key == Keys.S && moveAngle != "up")
                {
                    moveAngle = "down";
                    canMove = false;
                }
                if (key == Keys.A && moveAngle != "right")
                {
                    moveAngle = "left";
                    canMove = false;

                }
                if (key == Keys.D && moveAngle != "left")
                {
                    moveAngle = "right";
                    canMove = false;
                }
            }

        }
        private void Apple()
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
                            Image apple = SnakeImages.Images["apple.png"];
                            g.DrawImage(apple, appleX * 50, appleY * 50);
                            isAppleOnMap = true;
                            isTaken = false;
                        }
                    }
                }
            }
            else if (isAppleOnMap)
            {
                Image apple = SnakeImages.Images["apple.png"];
                g.DrawImage(apple, appleX * 50, appleY * 50);
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
            moveAngle = "up";
            isAppleOnMap = false;
            SnakeBody.Add(new SnakeCell(mapX / 2, mapY - 3));
            SnakeBody.Add(new SnakeCell(mapX / 2, mapY - 2));
            SnakeBody.Add(new SnakeCell(mapX / 2, mapY - 1));
        }
        private bool Death()
        {
            bool result = false;
            if (SnakeBody[0].x <= 0 || SnakeBody[0].x > mapX || SnakeBody[0].y <= 0 || SnakeBody[0].y > mapY)
            {
                result = true;
            }
            for (int i = 3; i <= snakeLength; i++)
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
            MainMenu mn = new MainMenu();
            this.Close();
            mn.Visible = true;

        }
        private void DrawSnake()
        {
            if (moveAngle == "up")
            {
                Image headUp = SnakeImages.Images["headUp.png"];
                g.DrawImage(headUp, SnakeBody[0].x * 50, SnakeBody[0].y * 50);
            }
            else if (moveAngle == "right")
            {
                Image headRight = SnakeImages.Images["headRight.png"];
                g.DrawImage(headRight, SnakeBody[0].x * 50, SnakeBody[0].y * 50);
            }
            else if (moveAngle == "down")
            {
                Image headDown = SnakeImages.Images["headDown.png"];
                g.DrawImage(headDown, SnakeBody[0].x * 50, SnakeBody[0].y * 50);
            }
            else if (moveAngle == "left")
            {
                Image headLeft = SnakeImages.Images["headLeft.png"];
                g.DrawImage(headLeft, SnakeBody[0].x * 50, SnakeBody[0].y * 50);
            }
            for (int i = 1; i < snakeLength; i++)
            {
                //checks if nearby cell is occupied
                bool downCell = ((SnakeBody[i].x == SnakeBody[i - 1].x) && (SnakeBody[i].y + 1 == SnakeBody[i - 1].y)) || ((SnakeBody[i].x == SnakeBody[i + 1].x) && (SnakeBody[i].y + 1 == SnakeBody[i + 1].y));
                bool upCell = ((SnakeBody[i].x == SnakeBody[i - 1].x) && (SnakeBody[i].y - 1 == SnakeBody[i - 1].y)) || ((SnakeBody[i].x == SnakeBody[i + 1].x) && (SnakeBody[i].y - 1 == SnakeBody[i + 1].y));
                bool leftCell = ((SnakeBody[i].x - 1 == SnakeBody[i - 1].x) && (SnakeBody[i].y == SnakeBody[i - 1].y)) || ((SnakeBody[i].x - 1 == SnakeBody[i + 1].x) && (SnakeBody[i].y == SnakeBody[i + 1].y));
                bool rightCell = ((SnakeBody[i].x + 1 == SnakeBody[i - 1].x) && (SnakeBody[i].y == SnakeBody[i - 1].y)) || ((SnakeBody[i].x + 1 == SnakeBody[i + 1].x) && (SnakeBody[i].y == SnakeBody[i + 1].y));

                //horizontal sprite
                if (rightCell && leftCell)
                {
                    Image horizontal = SnakeImages.Images["horizontal.png"];
                    g.DrawImage(horizontal, SnakeBody[i].x * 50, SnakeBody[i].y * 50);
                }
                //vertical sprite
                else if (upCell && downCell)
                {
                    Image vertical = SnakeImages.Images["vertical.png"];
                    g.DrawImage(vertical, SnakeBody[i].x * 50, SnakeBody[i].y * 50);
                }
                //up left sprite
                else if (upCell && leftCell)
                {
                    Image turnUpLeft = SnakeImages.Images["turnUpLeft.png"];
                    g.DrawImage(turnUpLeft, SnakeBody[i].x * 50, SnakeBody[i].y * 50);
                }
                //up right sprite
                else if (upCell && rightCell)
                {
                    Image turnUpRight = SnakeImages.Images["turnUpRight.png"];
                    g.DrawImage(turnUpRight, SnakeBody[i].x * 50, SnakeBody[i].y * 50);
                }
                //down left sprite
                else if (downCell && leftCell)
                {
                    Image turnDownLeft = SnakeImages.Images["turnDownLeft.png"];
                    g.DrawImage(turnDownLeft, SnakeBody[i].x * 50, SnakeBody[i].y * 50);
                }
                //down right sprite
                else if (downCell && rightCell)
                {
                    Image turnDownRight = SnakeImages.Images["turnDownRight.png"];
                    g.DrawImage(turnDownRight, SnakeBody[i].x * 50, SnakeBody[i].y * 50);
                }
            }
            int sl = snakeLength;
            bool upTail = ((SnakeBody[sl].x == SnakeBody[sl - 1].x) && (SnakeBody[sl].y - 1 == SnakeBody[sl - 1].y));
            bool downTail = ((SnakeBody[sl].x == SnakeBody[sl - 1].x) && (SnakeBody[sl].y + 1 == SnakeBody[sl - 1].y));
            bool leftTail = ((SnakeBody[sl].x - 1 == SnakeBody[sl - 1].x) && (SnakeBody[sl].y == SnakeBody[sl - 1].y));
            bool rightTail = ((SnakeBody[sl].x + 1 == SnakeBody[sl - 1].x) && (SnakeBody[sl].y == SnakeBody[sl - 1].y));
            if (upTail)
            {
                Image tailUp = SnakeImages.Images["tailUp.png"];
                g.DrawImage(tailUp, SnakeBody[sl].x * 50, SnakeBody[sl].y * 50);
            }
            else if (downTail)
            {
                Image tailDown = SnakeImages.Images["tailDown.png"];
                g.DrawImage(tailDown, SnakeBody[sl].x * 50, SnakeBody[sl].y * 50);
            }
            else if (leftTail)
            {
                Image tailLeft = SnakeImages.Images["tailLeft.png"];
                g.DrawImage(tailLeft, SnakeBody[sl].x * 50, SnakeBody[sl].y * 50);
            }
            else if (rightTail)
            {
                Image tailRight = SnakeImages.Images["tailRight.png"];
                g.DrawImage(tailRight, SnakeBody[sl].x * 50, SnakeBody[sl].y * 50);
            }
        }
        private void DrawBackground()
        {
            for (int y = 0; y <= mapY + 1; y++)
            {
                for (int x = 0; x <= mapX + 1; x++)
                {
                    if (x == 0 || y == 0 || x == mapX + 1 || y == mapY + 1)
                    {
                        var darkGrass = SnakeImages.Images["darkGrass.png"];
                        g.DrawImage(darkGrass, x * 50, y * 50);
                    }
                    else
                    {
                        Image grass = SnakeImages.Images["grass.png"];
                        g.DrawImage(grass, x * 50, y * 50);

                    }
                }
            }
        }
    }
}