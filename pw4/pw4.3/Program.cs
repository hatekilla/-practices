using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw4._3
{
    class Orc
    {
        public int Gold;
        public int AllOrcs;

        public Orc()
        {

        }

        public int orcsCount()
        {
            AllOrcs++;
            if (AllOrcs < 5)
            {
                return Gold += 2;
            }
            else
            {
                return Gold -= 2;
            }
        }


        public void total()
        {
            if (Gold < 0)
            {
                Console.WriteLine("Недостаточно золота");
            }
            else
            {
                Console.WriteLine($"Создано {AllOrcs} " +
                    $"\n Кол-во золота {Gold} ");
            }
        }

        class Program
        {
            static void Main()
            {
                Orc newOrc = new Orc();
                newOrc.orcsCount(); 
                newOrc.orcsCount();
                newOrc.orcsCount();
                newOrc.orcsCount();
                newOrc.orcsCount();
                newOrc.orcsCount();
                newOrc.orcsCount();
                newOrc.orcsCount();
                // newOrc.orcsCount(); // при попытке добавить еще одного орка игра сообщит о нехватке золота
                newOrc.total();
                Console.ReadKey(true);
            }
        }
    }
}
