using FlappyBirdByDarius.Gui;
using FlappyBirdByDarius.Gui.Controller;
using System;

namespace FlappyBirdByDarius
{
    enum UserAction
    {
        QUIT,
        CONTINUE,
        START
    }
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;

            MenuWindowController menuWindowController = new MenuWindowController();
            menuWindowController.ShowMenu();
        }
    }
}
