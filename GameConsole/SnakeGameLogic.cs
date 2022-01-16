//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace GameConsole
//{
//    class SnakeGameLogic : Form
//    {
        

//        public SnakeGameLogic()
//        {

//        }
//       // SnakeSpawn();
//        //Thread th = new Thread(() =>
//        //{
//        //    bool canMove = true;
//        //    while (!Death())
//        //    {
//        //        if (canMove)
//        //        {
//        //            ConsoleKeyInfo key;
//        //            key = Console.ReadKey();
//        //            switch (key.Key)
//        //            {
//        //                case ConsoleKey.UpArrow:
//        //                    if (moveAngle != 3)
//        //                    {
//        //                        MoveUp();
//        //                        canMove = false;
//        //                    }
//        //                    break;
//        //                case ConsoleKey.DownArrow:
//        //                    if (moveAngle != 1)
//        //                    {
//        //                        MoveDown();
//        //                        canMove = false;
//        //                    }
//        //                    break;
//        //                case ConsoleKey.LeftArrow:
//        //                    if (moveAngle != 2)
//        //                    {
//        //                        MoveLeft();
//        //                        canMove = false;
//        //                    }
//        //                    break;
//        //                case ConsoleKey.RightArrow:
//        //                    if (moveAngle != 4)
//        //                    {
//        //                        MoveRight();
//        //                        canMove = false;
//        //                    }
//        //                    break;
//        //            }
//        //        }
//        //        Thread.Sleep(250);
//        //        canMove = true;
//        //    }
//        //});
//        //th.Start();
//        //while (!Death())
//        //{
//       // AppleSpawn();
//       // SnakeMove();
//       // SnakeEat();
//        //DrawMap();
//        //Thread.Sleep(250);
//        //}

//        //SnakeGame();
//        //  SnakeSpawn();

//        public void SnakeGm()
//        {
//            SnakeSpawn();
//            //Thread th = new Thread(() =>
//            //{
//            //    bool canMove = true;
//            //    while (!Death())
//            //    {
//            //        if (canMove)
//            //        {
//            //            ConsoleKeyInfo key;
//            //            key = Console.ReadKey();
//            //            switch (key.Key)
//            //            {
//            //                case ConsoleKey.UpArrow:
//            //                    if (moveAngle != 3)
//            //                    {
//            //                        MoveUp();
//            //                        canMove = false;
//            //                    }
//            //                    break;
//            //                case ConsoleKey.DownArrow:
//            //                    if (moveAngle != 1)
//            //                    {
//            //                        MoveDown();
//            //                        canMove = false;
//            //                    }
//            //                    break;
//            //                case ConsoleKey.LeftArrow:
//            //                    if (moveAngle != 2)
//            //                    {
//            //                        MoveLeft();
//            //                        canMove = false;
//            //                    }
//            //                    break;
//            //                case ConsoleKey.RightArrow:
//            //                    if (moveAngle != 4)
//            //                    {
//            //                        MoveRight();
//            //                        canMove = false;
//            //                    }
//            //                    break;
//            //            }
//            //        }
//            //        Thread.Sleep(250);
//            //        canMove = true;
//            //    }
//            //});
//            //th.Start();
//            //while (!Death())
//            //{
//            AppleSpawn();
//            SnakeMove();
//            SnakeEat();
//            DrawMap();
//            //Thread.Sleep(250);
//            //}
//        }
        
//        public void SnakeMove()
//        {
//            for (int i = snakeLength; i >= 1; i--)
//            {
//                snakeX[i] = snakeX[i - 1];
//                snakeY[i] = snakeY[i - 1];
//            }
//            if (moveAngle == 1) //virsus
//            {
//                snakeX[0] = snakeX[0];
//                snakeY[0] = snakeY[0] - 1;
//            }
//            if (moveAngle == 2)//desine
//            {
//                snakeX[0] = snakeX[0] + 1;
//                snakeY[0] = snakeY[0];
//            }
//            if (moveAngle == 3)//apacia
//            {
//                snakeX[0] = snakeX[0];
//                snakeY[0] = snakeY[0] + 1;
//            }
//            if (moveAngle == 4)//kaire
//            {
//                snakeX[0] = snakeX[0] - 1;
//                snakeY[0] = snakeY[0];
//            }
//        }
//        public void SnakeEat()
//        {
//            if (snakeX[0] == appleX && snakeY[0] == appleY)
//            {
//                snakeX.Add(snakeX[snakeLength]);
//                snakeY.Add(snakeY[snakeLength]);
//                snakeLength++;
//                arYraOb = false;
//            }
//        }
//        public void AppleSpawn()
//        {
//            if (arYraOb == false)
//            {
//                rnd = new Random();
//                appleX = (byte)rnd.Next(1, mapX);
//                appleY = (byte)rnd.Next(1, mapY);
//                bool arYra = false;
//                while (!arYra)
//                {
//                    for (int i = 0; i <= snakeLength; i++)
//                    {
//                        if (appleX == snakeX[i] && appleY == snakeY[i])
//                        {
//                            appleX = (byte)rnd.Next(1, mapX);
//                            appleY = (byte)rnd.Next(1, mapY);
//                            arYra = false;
//                            break;
//                        }
//                        else
//                        {
//                            arYra = true;
//                        }
//                    }
//                }
//                arYraOb = true;
//            }
//        }
//        
        
//        public void MoveUp() { moveAngle = 1; }
//        public void MoveRight() { moveAngle = 2; }
//        public void MoveDown() { moveAngle = 3; }
//        public void MoveLeft() { moveAngle = 4; }
//        int sk = 0;
//    }
//}
