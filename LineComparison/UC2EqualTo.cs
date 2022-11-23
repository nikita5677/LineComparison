using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class UC2EqualTo
    {
        public static void EqualTo()
        {
            //Line 1
            Console.WriteLine("Enter the X1 and X2 Coordinates: ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y1 and Y2 Coordinates: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            double Result1 = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Line is : " + Result1);


            //Line 2
            Console.WriteLine("Enter the A1 and A2 Coordinates: ");
            int A1 = Convert.ToInt32(Console.ReadLine());
            int A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the B1 and B2 Coordinates: ");
            int B1 = Convert.ToInt32(Console.ReadLine());
            int B2 = Convert.ToInt32(Console.ReadLine());
            double Result2 = Math.Sqrt(Math.Pow((A2 - A1), 2) + Math.Pow((B2 - B1), 2));
            Console.WriteLine("Length of Line is : " + Result2);

            if (Result1 == Result2)
            {
                Console.WriteLine("Both the two lines are equal");
            }
            Console.ReadLine();
        }
    }
}