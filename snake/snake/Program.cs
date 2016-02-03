using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(3, 4, '*');
            a.Draw();
            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            line.Draw();
            Console.ReadKey();
        }
    }
}
