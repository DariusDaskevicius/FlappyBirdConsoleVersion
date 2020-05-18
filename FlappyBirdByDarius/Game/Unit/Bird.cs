using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FlappyBirdByDarius.Game.Unit
{
    class Bird
    {
        public int X { set; get; }
        public int Y { set; get; }

        ConsoleKeyInfo keyInfo;
        ConsoleKey consoleKey;

        public Bird(int x, int y)
        {
            X = x;
            Y = y;
            keyInfo = new ConsoleKeyInfo();
            consoleKey = new ConsoleKey();
        }

        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                consoleKey = keyInfo.Key;
            }
        }

        public void Logic()
        {
            Input();
            if (consoleKey == ConsoleKey.Spacebar)
            {
                Up();
            }
            else
            {
                Down();
            }
            consoleKey = ConsoleKey.A;
        }

        public void Write()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(X, Y - 1);
            Console.Write("▄");
            Console.SetCursorPosition(X - 1, Y - 1);
            Console.Write("▄");
            Console.SetCursorPosition(X - 1,Y);
            Console.Write("▀");
            Console.SetCursorPosition(X, Y);
            Console.Write("▀");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Write(string str)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(X, Y - 1);
            Console.Write(str);
            Console.SetCursorPosition(X - 1, Y - 1);
            Console.Write(str);
            Console.SetCursorPosition(X - 1, Y);
            Console.Write(str);
            Console.SetCursorPosition(X, Y);
            Console.Write(str);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Up()
        {
            Write("\0");
            Y--;
            Write();
        }

        public void Down()
        {
            Write("\0");
            Y++;
            Write();
        }
    }
}
