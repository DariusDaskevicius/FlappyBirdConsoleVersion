using System;
using System.Collections.Generic;
using System.Text;

namespace FlappyBirdByDarius.Gui.Model
{
    class Windows : GuiObject
    {
        private Frame _border;

        public Windows(int x, int y, int width, int height, char borderChar) : base(x, y, width, height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;

            _border = new Frame(x, y, width, height, borderChar);
        }

        public override void Render()
        {
            _border.Render();
        }
    }
}
