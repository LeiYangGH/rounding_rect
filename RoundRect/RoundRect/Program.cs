using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RoundRect
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point[] points = new Point[]
            //{
            //    new Point(0,0),
            //    new Point(0,1),
            //    new Point(1,1),
            //    new Point(1,0),
            //};
            Point[] points = new Point[]
{
                new Point(0,1),
                new Point(3,6),
                new Point(5,6),
                new Point(2,0),
};
            PointF[] pf4 = Calculator.CalcRectRoundingPoints(points);
            foreach (PointF pf in pf4)
            {
                Console.WriteLine(pf);
            }
            Console.ReadKey();
        }


    }
}
