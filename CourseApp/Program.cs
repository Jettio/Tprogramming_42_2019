using System;

namespace CourseApp
{
    public class Program
    {
        public static double EquatFunction(double a, double b, double x)
        {
            return (Math.Pow(Math.Pow(x - a, 2), 1.0 / 3.0) + Math.Pow(Math.Abs(x + b), 1.0 / 5.0)) / Math.Pow(Math.Pow(x, 2) - Math.Pow(a + b, 2), 1.0 / 9.0);
        }

        public static double[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            int size = (int)Math.Floor((xk - xn) / dx);
            double[] rtrn = new double[size + 1];
            size = 0;
            for (double x = xn; x < (xk + 0.1); x += dx)
            {
                rtrn[size] = EquatFunction(a, b, x);
                size++;
            }

            return rtrn;
        }

        public static double[] TaskB(double a, double b, double[] xm)
        {
            double[] rtrn = new double[xm.Length];
            for (int i = 0; i < xm.Length; i++)
            {
                rtrn[i] = EquatFunction(a, b, xm[i]);
            }

            return rtrn;
        }

        public static void Main(string[] args)
        {
            double a = 0.8;
            double b = 0.4;
            double[] mass = TaskA(a, b, 1.23, 7.23, 1.2);
            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }

            double[] mass2 = new double[5] { 1.88, 2.26, 3.84, 4.55, -6.21 };
            mass2 = TaskB(a, b, mass2);
            foreach (var item in mass2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------");
            Console.WriteLine(EquatFunction(1.0, 2.0, 5));

            Console.ReadKey();
        }
    }
}