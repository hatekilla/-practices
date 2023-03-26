using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw2._2
{

    class FindNumber
    {
        private int n = 0;
        bool proverka;
        private bool SetNumber(int number)
        {
            if (number == n + 1)
            {
                n = number;
                proverka = true;
                return proverka;
            }
            else
            {
                proverka = false;
                number = 1;
                n = 0;
                return proverka;
            }
        }
        public void NumberResult(int number)
        {
            while (number != 1)
            {
                Console.WriteLine("Введите 1 ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (true)
            {
                this.proverka = SetNumber(number);
                if (proverka == true)
                {
                    Console.WriteLine($"Введите число {n + 1}");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    NumberResult(number);

                }
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                int number = 0;
                FindNumber Find = new FindNumber();
                Find.NumberResult(number);
                Console.ReadKey(true);
            }
        }

    }
}

