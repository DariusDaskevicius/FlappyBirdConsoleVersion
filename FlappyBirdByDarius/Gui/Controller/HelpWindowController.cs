using FlappyBirdByDarius.Gui.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui.Controller
{
    class HelpWindowController
    {
        private readonly HelpWindow _helpWindow = new HelpWindow();

        public void ShowMenu()
        {
            ConsoleKeyInfo keyInfo;
            bool needToShowApp = true;
            do
            {
                _helpWindow.Render();
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.Enter:
                        MenuWindowController menuWindowController = new MenuWindowController();
                        menuWindowController.ShowMenu();
                        break;
                    default:
                        Console.WriteLine("Key not handled!");
                        break;
                }
            } while (needToShowApp);
        }
    }
}
