using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw5._2
{
    interface IHello
    {
        void SayHello();
    }

    class Eng : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("wassup");
        }
    }

    class Esp : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("buenos días");
        }
    }

    class Chn : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("你好");
        }
    }
    class Kz : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("салем");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IHello> salute = new List<IHello>();
            salute.Add(new Eng());
            salute.Add(new Esp());
            salute.Add(new Chn());
            salute.Add(new Kz());
            foreach (IHello hello in salute)
            {
                hello.SayHello();
            }
            Console.ReadKey(true);
        }
    }
}