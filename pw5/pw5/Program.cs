using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pw5
{
    interface IAnimal
    {
        void Voice();
    }
    class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Гав!");
        }
    }
    class Cat : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Мяу!");
        }
    }


    class Owl : IAnimal
    {
        private int GetCurrentTime()
        {
            return Convert.ToInt32(File.ReadAllText("current_time.txt"));
        }
        public void Voice()
        {
            int currentTime = GetCurrentTime();

            if ((currentTime >= 8) && (currentTime <= 21))
            {
                Console.WriteLine("Тисе, я сплю");
            }
            else
            {
                Console.WriteLine("Ух! Ух! Ух!");
            }
        }
    }

    class Hedgehog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Фыр-Фыр");
        }
    }
    class Crow : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Кар!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();

            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Hedgehog());
            myAnimals.Add(new Crow());

            foreach (IAnimal animal in myAnimals)
            {
                animal.Voice();
            }


            Console.ReadKey(true);
        }
    }

}
