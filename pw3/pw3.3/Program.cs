using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw3._3
{
    class sql
    {
        public string cmdtxt;
        public string cmd {get {return cmdtxt;} set {cmdtxt = shorter(value);}}
        private string shorter(string txt)
        {
            return txt.Replace("sel", "SELECT")
                .Replace("cr", "CREATE")
                .Replace("fr", "FROM")
                .Replace("al", "ALTER")
                .Replace("dr", "DROP")
                .Replace("ins", "INSERT")
                .Replace("del", "DELETE")
                .Replace("upd", "UPDATE");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            sql sqlcomm = new sql();
            Console.Write("sql command shorter" +
                "\n enter your request - ");
            sqlcomm.cmd = Console.ReadLine();
            Console.Write($"\n result:" +
                $"\n {sqlcomm.cmd}");
            Console.ReadKey();
        }
    }
}
