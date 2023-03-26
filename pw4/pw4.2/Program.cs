using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw4._2
{
    class Package
    {
        public string PackageName { get; private set; }
        public double Weight { get; private set; }

        public Package(string packageName, double weight)
        {
            PackageName = packageName;
            Weight = weight;
        }
    }
    class Delivery
    {
        private double MaxWeight { get; set; }
        private double PackageWeight;

        public Delivery(int maxWeight)
        {
            MaxWeight = maxWeight;
        }
        public void Send(Package package)
        {
            if (MaxWeight >= (PackageWeight += package.Weight))
            {

                Console.WriteLine($"Вес посылки {PackageWeight}");
            }
            else
            {
                Console.WriteLine($"Вес вашей посылки {PackageWeight -100}, к сожалению, мы не можем отправлять посылки весом более {MaxWeight} кг");
            }
        }
        class Program
        {
            static void Main()
            {
                Package courier1 = new Package("diffusal blade", 100);
                Package courier2 = new Package("heart of tarrasque", 300);

                Delivery mail = new Delivery(200);
                mail.Send(courier1);
                mail.Send(courier2);
                Console.ReadKey(true);
            }
        }
    }
}
