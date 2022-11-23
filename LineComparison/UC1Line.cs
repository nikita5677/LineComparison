using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class UC1Line
    {
        public static void Line()
        {
            Console.WriteLine("Enter the X1 and X2 Coordinates: ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y1 and Y2 Coordinates: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            double Result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Line is : " + Result);
            Console.ReadLine();
        }
    }
}