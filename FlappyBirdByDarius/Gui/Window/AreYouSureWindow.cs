using FlappyBirdByDarius.Gui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui.Window
{
    class AreYouSureWindow : Windows
    {
        private List<Button> _yesNoButtons = new List<Button>();
        private int _activeButtonNr;
        private TextBlocks _yesNoTextBlock;

        public int ActiveButtonNr
        {
            get
            {
                return _activeButtonNr;
            }
            private set
            {
                _yesNoButtons[_activeButtonNr].IsActive = false;
                _activeButtonNr = value;
                _yesNoButtons[_activeButtonNr].IsActive = true;
            }
        }

        public AreYouSureWindow() : base(0, 0, 77, 30, '%')
        {
            _yesNoTextBlock = new TextBlocks(32, 10, 0, new List<string> { "Are you sure?" });


            _yesNoButtons.Add(new Button(15, 15, 18, 5, "YES"));
            _yesNoButtons.Add(new Button(44, 15, 18, 5, "NO"));
            _activeButtonNr = 0;
        }

        public override void Render()
        {
            base.Render();

            _yesNoTextBlock.Render();

            foreach (Button button in _yesNoButtons)
            {
                button.Render();
            }

            Console.SetCursorPosition(0, 0);
        }

        public void GoLeft()
        {
            if (_activeButtonNr > 0)
            {
                ActiveButtonNr--;
            }
        }

        public void GoRight()
        {
            if (_activeButtonNr < _yesNoButtons.Count - 1)
            {
                ActiveButtonNr++;
            }
        }

    }
}
