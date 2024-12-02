using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Forms5
{
    public abstract class Figure
    {
        protected int centerX;
        protected int centerY;

        protected Figure(int centerX, int centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (int i = 0; i < 50; i++)
            {
                DrawBlack();
                Thread.Sleep(100);
                HideDrawingBackGround();
                centerX++;
            }
        }
    }
}
