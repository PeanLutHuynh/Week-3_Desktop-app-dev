using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    internal class Solver
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Solver(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        public (double? x1, double? x2) Solve()
        {
            double delta = B * B - 4 * A * C;

            if (A == 0)
            {
                double x = -C / B;
                return (x, null);
            }
            else if (delta < 0)
            {
                return (null, null);
            }
            else if (delta == 0)
            {
                double x = -B / (2 * A);
                return (x, null);
            }
            else
            {
                double x1 = Math.Round((-B + Math.Sqrt(delta)) / (2 * A),2);
                double x2 = Math.Round((-B - Math.Sqrt(delta)) / (2 * A),2);
                return (x1, x2);
            }
        }
    }
}
