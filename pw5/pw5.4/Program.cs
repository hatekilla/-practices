using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw5._4
{
    interface IShare
    {
        void Draw(int size);
    }

    public class VerticalLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("l");
            }
        }
    }

    public class HorizontalLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
    }

    public class Square : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShare verticalLine = new VerticalLine();
            Console.WriteLine("Vertical Line:");
            verticalLine.Draw(5);
            Console.WriteLine();
            IShare horizontalLine = new HorizontalLine();
            Console.WriteLine("Horizontal Line:");
            horizontalLine.Draw(10);
            Console.WriteLine();
            IShare square = new Square();
            Console.WriteLine("Square:");
            square.Draw(4);
            Console.WriteLine("Enter чтобы закрыть это окно .. ");
            Console.ReadLine();
        }
    }
}

