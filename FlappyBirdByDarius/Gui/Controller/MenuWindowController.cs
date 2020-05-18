using FlappyBirdByDarius.Game.Unit;
using FlappyBirdByDarius.Gui.Model;
using FlappyBirdByDarius.Gui.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui.Controller
{
    class MenuWindowController
    {
        private readonly MenuWindow _menuWindow = new MenuWindow();

        public void ShowMenu()
        {
            ConsoleKeyInfo keyInfo;
            bool needToShowApp = true;
            do
            {
                _menuWindow.Render();
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        _menuWindow.GoDown();
                        break;
                    case ConsoleKey.UpArrow:
                        _menuWindow.GoDUp();
                        break;
                    case ConsoleKey.LeftArrow:
                        _menuWindow.GoLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        _menuWindow.GoRight();
                        break;
                    case ConsoleKey.Enter:
                        int currentSelection = _menuWindow.ActiveButtonNr;
                        if (currentSelection == 0)
                        {
                            Console.Title = "Console Flapp Brid";
                            Console.CursorVisible = false;
                            GameController flappy = new GameController(75, 20);
                            flappy.Run();
                            Console.ReadKey();
                        }
                        else if (currentSelection == 1)
                        {
                            HelpWindowController helpWindowController = new HelpWindowController();
                            helpWindowController.ShowMenu();
                        }
                        else if (currentSelection == 2)
                        {
                            CreditWindowController creditWindowController = new CreditWindowController();
                            creditWindowController.ShowMenu();
                        }
                        else if (currentSelection == 3)
                        {
                            AreYouSureController areYouSureController = new AreYouSureController();
                            areYouSureController.ShowMenu();
                        }
                        break;
                    default:
                        Console.WriteLine("Key not handled!");
                        break;
                }

            } while (needToShowApp);
        }
    }
}
