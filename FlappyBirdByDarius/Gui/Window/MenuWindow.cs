using FlappyBirdByDarius.Gui.Model;
using FlappyBirdByDarius.Gui.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui
{
    class MenuWindow : Windows
    {
        private TextBlocks _titleTextBlock;
        private int _activeButtonNr;
        private List<Button> _menuButtons = new List<Button>();

        private string flappyBird = 
@"          ##### #     ##### ###### ##### #   #
%                     #     #     #   # #    # #   #  # #
%                     ##### #     ##### ###### #####   #
%                     #     #     #   # #      #       #
%                     #     ##### #   # #      #       #
%                       
%                            #####  # ##### ####
%                            #    # # #   # #   #
%                            ###### # ##### #    #
%                            #    # # #  #  #   #
%                            #####  # #   # ####"; 

        public int ActiveButtonNr
        {
            get
            {
                return _activeButtonNr;
            }
            private set
            {
                _menuButtons[_activeButtonNr].IsActive = false;
                _activeButtonNr = value;
                _menuButtons[_activeButtonNr].IsActive = true;
            }
        }

        public MenuWindow() : base(0, 0, 77, 30, '%')
        {
            _titleTextBlock = new TextBlocks(12, 1, 0, new List<string> { flappyBird });

            _menuButtons.Add(new Button(15, 15, 18, 5, "Play"));
            _menuButtons.Add(new Button(15, 22, 18, 5, "Help"));
            _menuButtons.Add(new Button(44, 15, 18, 5, "Credits"));
            _menuButtons.Add(new Button(44, 22, 18, 5, "Exit"));

            _activeButtonNr = 0;
        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();

            foreach (Button button in _menuButtons)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);
        }

        public void GoDUp()
        {
            if (_activeButtonNr > 0)
            {
                ActiveButtonNr--;
            }
        }

        public void GoDown()
        {
            if (_activeButtonNr < _menuButtons.Count - 1)
            {
                ActiveButtonNr++;
            }
        }

        public void GoLeft()
        {
            if (_activeButtonNr == 2 || _activeButtonNr == 3)
            {
                ActiveButtonNr -= 2;
            }
        }

        public void GoRight()
        {
            if (_activeButtonNr == 0 || _activeButtonNr == 1)
            {
                ActiveButtonNr += 2;
            }
        }


    }
}
