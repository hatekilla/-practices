using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw3._2
{
    class SmsMessage
    {
        public double defaultmsg;
        public string text;
        public double Price { get { return price(text); } }
        public string MessageText { get { return text; } set { text = limited(value); } }
        private string limited(string message)
        {
            if (message.Length > 250)
            {
                return message.Substring(0, message.Length - (message.Length - 250));
            }
            return message;
        }

        public double price(string symbols)
        {
            if (symbols.Length < 65)
            {
                return defaultmsg = symbols.Length * 1.5;
            }
            else
            {
                return defaultmsg = symbols.Length + 0.5;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SmsMessage smstext = new SmsMessage();
            Console.Write("roflanmessager " +
                "\n enter your message no more than 250 letters" +
                "\n message price = " +
                "\n >65 = 0.5rub" +
                "\n <65 = 1.5rub \n");
            smstext.MessageText = Console.ReadLine();
            Console.Write($"length: {smstext.text.Length}:" +
                $"\n price: {smstext.Price}");
            Console.ReadKey(true);
        }
    }
}
