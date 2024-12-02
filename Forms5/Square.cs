using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Forms5
{

    public class Square : Figure
    {
        private int sideLength;

        public Square(int centerX, int centerY, int sideLength)
            : base(centerX, centerY)
        {
            this.sideLength = sideLength;
        }

        private Point[] GetPoints()
        {
            int half = sideLength / 2;
            return new Point[]
            {
            new Point(centerX - half, centerY - half),
            new Point(centerX - half, centerY + half),
            new Point(centerX + half, centerY + half),
            new Point(centerX + half, centerY - half)
            };
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, GetPoints());
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), GetPoints());
        }
    }
}
