using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadriticEquationSolver
{
    public class EquationSolver
    {
        public static void SolverMethod()
        {
            Console.Write("Input number a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Input number b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Input number c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double d = (b * b) - 4 * (a * c);
            Console.WriteLine();

            if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;

                Console.WriteLine("The equation has two solutions: ");
                Console.Write("x1 = " + x1 + "          " + "x2 = " + x2);
                Console.WriteLine();
            }

            else if (d == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("The equation has one solution: ");
                Console.Write("x = " + x);
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("The equation has no solution.");
                Console.WriteLine();
            }

            
        }
    }
}
