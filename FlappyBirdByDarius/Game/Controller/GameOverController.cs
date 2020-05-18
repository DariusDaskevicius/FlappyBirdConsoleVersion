using FlappyBirdByDarius.Game.Unit;
using FlappyBirdByDarius.Game.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui.Controller
{
    class GameOverController
    {
        private readonly GameOverWindow gameOverWindow = new GameOverWindow();

        public void ShowMenu()
        {
            ConsoleKeyInfo keyInfo;
            bool needToShowApp = true;

            do
            {
                gameOverWindow.Render();
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.P:
                        GameController gameController = new GameController(75,20);
                        gameController.Run();
                        break;
                    case ConsoleKey.Q:
                        MenuWindowController menuWindowController = new MenuWindowController();
                        menuWindowController.ShowMenu();
                        break;
                }
            } while (needToShowApp);
        }
    }
}
