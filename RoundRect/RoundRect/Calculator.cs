using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundRect
{
    public static class Calculator
    {
        public static PointF CalcOutPointOf2(Point ps, Point pe)
        {
            double r2 = Math.Sqrt(2);
            double a = Math.Atan2(ps.Y - pe.Y, ps.X - pe.X);
            //Console.WriteLine($"a={a}");
            double b = -Math.PI / 4 - (Math.PI / 2 - a);
            //Console.WriteLine($"b={b}");
            double x = pe.X + r2 * Math.Cos(b);
            double y = pe.Y + r2 * Math.Sin(b);
            return new PointF((float)x, (float)y);
        }

        public static PointF[] CalcRectRoundingPoints(Point[] points)
        {
            //Debug.Assert(points.Length == 4);

            Point[] p5 = new Point[] {
                points[3],
                points[0],
                points[1],
                points[2],
                points[3] };
            PointF[] pf4 = new PointF[4];
            for (int i = 0; i < 4; i++)
            {
                Point ps = p5[i];
                Point pe = p5[i + 1];
                pf4[i] = CalcOutPointOf2(ps, pe);
            }
            return pf4;
        }
    }
}
