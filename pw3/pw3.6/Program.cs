﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw3._6
{
    class MyRandomList
    {
        private List<int> numbersList = new List<int>();
        Random rand = new Random();
        private int n{ set{SetLength(value);} }
        public double Average{ get{return CalculateAverage();} }
        public double Dispersion{ get{return CalculateDispersion();} }
        public double Deviation{ get{return CalculateStandardDeviation();} }
        public double Median{ get{return CalculateMedian();} }
        //
        private void SetLength(int n)
        {
            n = numbersList.Count;
        }

        public void AddNumber()
        {
            numbersList.Add(rand.Next(101));
        }

        public void RemoveNumber(int number)
        {
            numbersList.Remove(number);
        }

        private double CalculateAverage()
        {
            int sum = 0;
            foreach (int number in numbersList)
            {
                sum += number;
            }
            return sum / numbersList.Count;
        }

        private double CalculateDispersion()
        {
            double sum = 0;
            foreach (int number in numbersList)
            {
                sum += Math.Pow((number - Average), 2);
            }
            return Math.Round(sum / numbersList.Count, 2);
        }

        private double CalculateStandardDeviation()
        {
            CalculateDispersion();
            return Math.Round(Math.Sqrt(Dispersion), 2);
        }

        private double CalculateMedian()
        {
            numbersList.Sort();
            if (numbersList.Count % 2 == 0)
            {
                return (numbersList[numbersList.Count / 2] + numbersList[numbersList.Count / 2 - 1]) / 2;
            }
            else
            {
                double middle = numbersList.Count / 2;
                middle = Math.Ceiling(middle);
                return numbersList[Convert.ToInt32(middle)];
            }
        }

        static void Main(string[] args)
        {
            MyRandomList numbers = new MyRandomList();
            for (int i = 0; i < 11; i++)
            {
                numbers.AddNumber();
            }
            Console.WriteLine($"Дисперсия - {numbers.Dispersion}");
            Console.WriteLine($"\nСреднеквадратическое отклонение - {numbers.Deviation}");
            Console.WriteLine($"\nМедиана - {numbers.Median}");
            Console.ReadKey(true);
        }
    }
}