using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1Line.Line();
            Console.ReadLine();

            UC2EqualTo.EqualTo();
            Console.ReadLine();

            UC3GreaterThan.GreaterThan();
            Console.ReadLine();
        }
    }
}