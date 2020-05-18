using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FlappyBirdByDarius.Game.Unit
{
    class Wall
    {
        public int X { set; get; }
        public int Y { set; get; }
        Random random;
        int boardWidth;
        int boardHeight;

        public Wall(int x, int boardWidth, int boardHeight)
        {
            this.boardWidth = boardWidth;
            this.boardHeight = boardHeight;
            random = new Random();
            X = x;
            Y = random.Next(3, boardHeight - 2);
            Thread.Sleep(10);
        }

        public void Move()
        {
            Write("\0");
            X--;
            Write();
            if (X - 2 <= 0)
            {
                X = 75;
                Y = random.Next(3, boardHeight - 2);
            }
        }

        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (X - 2 >= 1 && X + 2 <= boardWidth-1)
            {
                for (int i = 1; i < Y - 2; i++)
                {
                    Console.SetCursorPosition(X - 2, i);
                    Console.Write("│");
                    Console.SetCursorPosition(X + 2, i);
                    Console.Write("│");
                }
                for (int i = boardHeight; i > Y + 2; i--)
                {
                    Console.SetCursorPosition(X - 2, i);
                    Console.Write("│");
                    Console.SetCursorPosition(X + 2, i);
                    Console.Write("│");
                }
                for (int i = X - 1; i < X + 2; i++)
                {
                    Console.SetCursorPosition(i, Y + 2);
                    Console.Write("─");
                    Console.SetCursorPosition(i, Y - 2);
                    Console.Write("─");
                }
                Console.SetCursorPosition(X + 2, Y - 2);
                Console.Write("┘");
                Console.SetCursorPosition(X - 2, Y - 2);
                Console.Write("└");
                Console.SetCursorPosition(X + 2, Y + 2);
                Console.Write("┐");
                Console.SetCursorPosition(X - 2, Y + 2);
                Console.Write("┌");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Write(string str)
        {
            if (X - 2 >= 1 && X + 2 <= boardWidth - 1)
            {
                for (int i = 1; i < Y - 2; i++)
                {
                    Console.SetCursorPosition(X - 2, i);
                    Console.Write(str);
                    Console.SetCursorPosition(X + 2, i);
                    Console.Write(str);
                }
                for (int i = boardHeight; i > Y + 2; i--)
                {
                    Console.SetCursorPosition(X - 2, i);
                    Console.Write(str);
                    Console.SetCursorPosition(X + 2, i);
                    Console.Write(str);
                }
                for (int i = X - 1; i < X + 2; i++)
                {
                    Console.SetCursorPosition(i, Y + 2);
                    Console.Write(str);
                    Console.SetCursorPosition(i, Y - 2);
                    Console.Write(str);
                }
                Console.SetCursorPosition(X + 2, Y - 2);
                Console.Write(str);
                Console.SetCursorPosition(X - 2, Y - 2);
                Console.Write(str);
                Console.SetCursorPosition(X + 2, Y + 2);
                Console.Write(str);
                Console.SetCursorPosition(X - 2, Y + 2);
                Console.Write(str);
            }
        }

    }
}
