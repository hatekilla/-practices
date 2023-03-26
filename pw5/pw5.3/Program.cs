using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw5._3
{
    interface IFilter
    {
        string Execute(string textline);
    }

    public class DigitFilter : IFilter
    {
        public string Execute(string textline)
        {
            string result = "";
            foreach (char c in textline)
            {
                if (!char.IsDigit(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }

    public class LetterFilter : IFilter
    {
        public string Execute(string textline)
        {
            string result = "";
            foreach (char c in textline)
            {
                if (!char.IsLetter(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFilter digitFilter = new DigitFilter();
            string result1 = digitFilter.Execute("абв123abc"); // выведет буквы
            IFilter letterFilter = new LetterFilter();
            string result2 = letterFilter.Execute("абв123abc"); // выведет цифры
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadLine();
            Console.WriteLine("Нажмите Enter чтобы закрыть это окно..");
        }
    }
}