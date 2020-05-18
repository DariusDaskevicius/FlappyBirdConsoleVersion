using FlappyBirdByDarius.Gui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui.Window
{
    class HelpWindow : Windows
    {
        private Button _backButton;

        private TextBlocks _helpTextBlock;

        private string creditInfo =
@"       
%                             Settings 
%                        Window height : 30
%                         Window width : 77
%
%                             Controls 
%                                  Fly : Space
%                                 Menu : Keyboard arrows
%                              Restart : P
%                                 Quit : Q
%                     
%                           High score : Soon...
%                                   
%                      
";


        public HelpWindow() : base(0, 0, 77, 30, '%')
        {
            List<string> creditData = new List<string>();

            creditData.Add(creditInfo);

            _helpTextBlock = new TextBlocks(30, 3, 0, creditData);

            _backButton = new Button(29, 21, 18, 5, "Back");
            _backButton.IsActive = true;
        }

        public override void Render()
        {
            base.Render();
            _helpTextBlock.Render();
            _backButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
