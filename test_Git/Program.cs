using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            const int c = 100;

            Console.WriteLine("a / b у відсотках: " + (a / b * c).ToString() + "%\n");
            Console.ReadLine();
        }
    }
}
