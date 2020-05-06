using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_1_Library;

namespace HomeWork_1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticLibraty NewTask = new QuadraticLibraty();

            Console.WriteLine("ax^2+bx+c=0");

            Console.Write("a=");
            var a = Handler();
            Console.Write("b=");
            var b = Handler();
            Console.Write("c=");
            var c = Handler();

            var result = NewTask.GetResult(a, b, c);

            Console.WriteLine($"x_1 = {result[0]}, x_2 = {result[1]}");

            Console.ReadKey();
        }

        static double Handler()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Wrong Number: ");
            }
            return number;
        }
    }
}
