using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyIntList numbers = new MyIntList();
            Console.WriteLine("how much number will be");
            int totalNumbers = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < totalNumbers; i++)
            {
                Console.WriteLine("enter a number");
                int newNumber = Convert.ToInt32(Console.ReadLine());
                numbers.AddNumber(newNumber);
            }
            Console.WriteLine($" avg: {numbers.Average}");
            Console.ReadKey(true);
        }
    }
    class MyIntList
    {
        private List<int> numberList = new List<int>();
        public double Average
        {
            get
            {
                return CalculateAverage();
            }
        }
        public void AddNumber(int number)
        {
            numberList.Add(number);
        }



        public void RemoveNumber(int number)
        {
            numberList.Remove(number);
        }
        private double CalculateAverage()
        {
            int sum = 0;
            foreach (int number in numberList)
            {
                sum += number;
            }
            return sum / (double)numberList.Count;
        }
    }
}
