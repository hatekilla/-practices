using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw1
{
    class player
    {
        public double gpm;
        public double calc(double distance)
        {
            return Math.Round(distance / gpm);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double distance = rnd.Next(60000, 65000); ;

            player yatoro = new player();
            yatoro.gpm = rnd.Next(60, 120);
            double yatorotime = yatoro.calc(distance);

            player shiro = new player();
            shiro.gpm = rnd.Next(60, 120);
            double shirotime = shiro.calc(distance);

            player ramzes666 = new player();
            ramzes666.gpm = rnd.Next(60, 120);
            double ramzes666time = ramzes666.calc(distance);

            player pure = new player();
            pure.gpm = rnd.Next(60, 120);
            double puretime = pure.calc(distance);

            //

            Console.WriteLine("gpm race");
            if (yatoro.gpm > shiro.gpm || yatoro.gpm > ramzes666.gpm || yatoro.gpm > pure.gpm)
            {
                Console.WriteLine($"yatoro perefarmil rakov \n { yatorotime } gpm"); 
            }
            else
            if (shiro.gpm > yatoro.gpm || shiro.gpm > ramzes666.gpm || shiro.gpm > pure.gpm)
            {
                Console.WriteLine($"chinese mindset na babki \n { shirotime } gpm");
            }
            else
            if (ramzes666.gpm > shiro.gpm || ramzes666.gpm > yatoro.gpm || ramzes666.gpm > pure.gpm)
            {
                Console.WriteLine($"ramzes: 5 majorov viigral v dote. a?) \n { ramzes666time } gpm ");
            }
            else
            if (pure.gpm > shiro.gpm || pure.gpm > ramzes666.gpm || pure.gpm > yatoro.gpm)
            {
                Console.WriteLine($"pure ne ostavil shansov { puretime } gpm ");
            }


            // 
            Console.ReadKey(true);
        }
    }
}
