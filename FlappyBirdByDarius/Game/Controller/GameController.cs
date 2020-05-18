using FlappyBirdByDarius.Game.Data;
using FlappyBirdByDarius.Gui.Controller;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.IO;

namespace FlappyBirdByDarius.Game.Unit
{
    class GameController
    {
        int Width { get; set; }
        int Height { get; set; }

        Board board;
        Bird bird;
        Wall wall1;
        Wall wall2;
        Wall wall3;
        int score;


        public GameController(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Setup()
        {
            board = new Board(Width, Height);
            bird = new Bird(Height, Height / 2);
            wall1 = new Wall(35, Width, Height);
            wall2 = new Wall(60, Width, Height);
            wall3 = new Wall(85, Width, Height);
            score = 0;
            board.Write();
            Console.SetCursorPosition((Width / 2) - 4, Height + 2);
            Console.Write("Score: ");
            Console.WriteLine(@"
                            Tap 'Space' to fly");
            bird.Write();
            wall1.Move();
            wall2.Move();
            wall3.Move();
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Setup();
                Console.ReadKey(true);
                while (bird.Y < Height && bird.Y > 1)
                {
                    if (((bird.X >= wall1.X - 2 && bird.X <= wall1.X + 2) && (bird.Y <= wall1.Y - 1 || bird.Y >= wall1.Y + 2))
                        || ((bird.X >= wall2.X - 2 && bird.X <= wall2.X + 2) && (bird.Y <= wall2.Y - 1 || bird.Y >= wall2.Y + 2))
                        || ((bird.X >= wall3.X - 2 && bird.X <= wall3.X + 2) && (bird.Y <= wall3.Y - 1 || bird.Y >= wall3.Y + 2)))
                    {
                        Console.Beep();
                        GameOverController highScoreController = new GameOverController();
                        highScoreController.ShowMenu();
                    }
                    if (wall1.X == bird.X || wall2.X == bird.X || wall3.X == bird.X)
                    {
                        score++;
                    }
                    bird.Logic();
                    wall1.Move();
                    wall2.Move();
                    wall3.Move();
                    Console.SetCursorPosition((Width / 2) + 3, Height + 2);
                    Console.Write(score);
                    Thread.Sleep(300);
                }
            }
        }
    }
}
