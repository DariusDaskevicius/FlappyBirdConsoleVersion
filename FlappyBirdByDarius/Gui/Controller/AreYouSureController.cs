using FlappyBirdByDarius.Gui.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui.Controller
{
    class AreYouSureController
    {
        private readonly AreYouSureWindow _areYouSureWindow = new AreYouSureWindow();

        public void ShowMenu()
        {
            ConsoleKeyInfo keyInfo;
            bool needToShowApp = true;
            do
            {
                _areYouSureWindow.Render();
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        _areYouSureWindow.GoLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        _areYouSureWindow.GoRight();
                        break;
                    case ConsoleKey.Enter:
                        int currentSelection = _areYouSureWindow.ActiveButtonNr;
                        if (currentSelection == 0)
                        {
                            Environment.Exit(0);
                        }
                        else if(currentSelection == 1)
                        {
                            MenuWindowController menuWindowController = new MenuWindowController();
                            menuWindowController.ShowMenu();
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
