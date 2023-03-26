using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw2
{
        class yravnenie
        {
        private double a, b, c, d, x1, x2;
        public void ratio(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        private double disc(double a, double b, double c)
        {
            d = b * b - 4 * a * c;
            return d;
        }

        public void CalculateRoots()
        {
            this.d = disc(a, b, c);
            Console.WriteLine($"{d}");
            if (d < 0)
            {
                Console.WriteLine("Корней нет");
            }
            if (d == 0)
            {
                Console.WriteLine($"  Корень равен{ (-b) / (2 * a) }");
            }
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"x1 = {x1} \n x2 = {x2}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                yravnenie square = new yravnenie();
                Console.WriteLine("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n c = ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n d = ");
                square.ratio(a, b, c);
                square.CalculateRoots();
                Console.WriteLine("\n Нажмите любую клавишу чтобы выйти..");
                Console.ReadKey(true);
                
            }
        }

    }

}
