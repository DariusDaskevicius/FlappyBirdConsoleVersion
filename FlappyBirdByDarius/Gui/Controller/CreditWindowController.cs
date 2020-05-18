using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui.Controller
{
    class CreditWindowController
    {
        private readonly CreditWindow _creditWindow = new CreditWindow();

        public void ShowMenu()
        {
            ConsoleKeyInfo keyInfo;
            bool needToShowApp = true;
            do
            {
                _creditWindow.Render();
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
