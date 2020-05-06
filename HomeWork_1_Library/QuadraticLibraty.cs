using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork_1_Library
{
    public class QuadraticLibraty
    {
        public double[] GetResult(double a, double b, double c)
        {
            double[] Result = new double[2];
            double x_1 = 0, x_2 = 0;
            var discriminant = b * b - 4 * a * c;
            if (a == 0)
            {
                throw new InvalidOperationException("First coeficient can't be 0");
            }
            if (discriminant < 0)
            {
                throw new OperationCanceledException("Wrong incoming parameter");
            }
            if (discriminant == 0)
            {
                x_1 = -b / (2 * a);
                x_2 = x_1;
            }
            if (discriminant > 0)
            {
                x_1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                x_2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            }

            Result[0] = x_1;
            Result[1] = x_2;
            return Result;
        }
    }
}
