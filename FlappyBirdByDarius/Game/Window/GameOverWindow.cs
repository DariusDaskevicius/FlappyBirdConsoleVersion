using FlappyBirdByDarius.Gui;
using FlappyBirdByDarius.Gui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Game.Window
{
    class GameOverWindow : Windows
    {
        private TextBlocks _gameOverTextBlocks;

        private string gameOverText = 
@"
                   %              Game over!
                   %         Press 'P' to restart
                   %          Press 'Q' to quit";
        


        public GameOverWindow() : base (19,5, 40, 7, '%')
        {
            _gameOverTextBlocks = new TextBlocks(19, 5, 10, new List<string> { gameOverText });

        }

        public override void Render()
        {
            base.Render();

            _gameOverTextBlocks.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
