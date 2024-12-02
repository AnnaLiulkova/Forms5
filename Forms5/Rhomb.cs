using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Forms5
{
    public class Rhomb : Figure
    {
        private int horDiagLen;
        private int vertDiagLen;

        public Rhomb(int centerX, int centerY, int horDiagLen, int vertDiagLen)
            : base(centerX, centerY)
        {
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
        }

        private Point[] GetPoints()
        {
            return new Point[]
            {
            new Point(centerX, centerY - vertDiagLen / 2), // Верхня точка
            new Point(centerX + horDiagLen / 2, centerY), // Права точка
            new Point(centerX, centerY + vertDiagLen / 2), // Нижня точка
            new Point(centerX - horDiagLen / 2, centerY)  // Ліва точка
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