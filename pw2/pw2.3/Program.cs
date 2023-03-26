using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw2._3
{
    class caesar
    {
        private char[] rus = "йцукенгшщзхъфывапролджэячсмитьбюё".ToCharArray();
        private char[] eng = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
        private int allcount, newcount, j;
        private string newText;
        public void CaesarConvertRu(char[] textToArray)
        {
            for (int i = 0; i < textToArray.Length; i++)
            {
                for (j = 0; j < rus.Length; j++)
                {
                    if (textToArray[i] == rus[j])
                    {
                        break;
                    }
                }

                if (j != 33)
                {
                    allcount = j;
                    newcount = allcount + 3;

                    if (newcount > 32)
                    {
                        newcount = newcount - 33;
                    }

                    textToArray[i] = rus[newcount];
                }
            }

            newText = new string(textToArray);
            Console.WriteLine(newText);
        }
        public void CaesarConvertEn(char[] textToArray)
        {
            for (int i = 0; i < textToArray.Length; i++)
            {
                for (j = 0; j < eng.Length; j++)
                {
                    if (textToArray[i] == eng[j])
                    {
                        break;
                    }
                }

                if (j != 26)
                {
                    allcount = j;
                    newcount = allcount + 3;

                    if (newcount > 25)
                    {
                        newcount = newcount - 26;
                    }

                    textToArray[i] = eng[newcount];
                }
            }

            newText = new string(textToArray);
            Console.WriteLine(newText);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose language \n1- eng \n2- rus");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ur text");
            caesar Cipher = new caesar();
            string text = Convert.ToString(Console.ReadLine());
            text = text.ToLower();
            char[] textToArray = text.ToCharArray();
            if (type == 2)
            {

                Cipher.CaesarConvertRu(textToArray);
            }
            else
            {
                Cipher.CaesarConvertEn(textToArray);
            }


            Console.ReadKey();
        }
    }

}
