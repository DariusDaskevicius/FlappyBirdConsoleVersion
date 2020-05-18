using FlappyBirdByDarius.Gui.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui
{
    class CreditWindow : Windows
    {
        private Button _backButton;

        private TextBlocks _creditTextBlock;

        private string creditInfo =
@"       
%                                 ______________________
%                                /    Game design:     //
%                               / Darius Daskevicius  //
%                              /                     //
%                             /   Programuotojas:   //
%                            / Darius Daskevicius  //
%                           /                     //
%                          /        Art:         //
%                         / Darius Daskevicius  //
%                        /                     //
%                       /    Marketingas:     //
%                      / Darius Daskevicius  //
%                     /_____________________//
%                    (_____________________(/)
";


        public CreditWindow() : base(0, 0, 77, 30, '%')
        {
            List<string> creditData = new List<string>();

            creditData.Add(creditInfo);

            _creditTextBlock = new TextBlocks(30, 1, 0, creditData);

            _backButton = new Button(29, 21, 18, 5, "Back");
            _backButton.IsActive = true;
        }

        public override void Render()
        {
            base.Render();
            _creditTextBlock.Render();
            _backButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
}
