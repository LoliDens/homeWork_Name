using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            char userSymbol;
            string lineChar = "";
            string userNameAndSymbols;

            Console.Write("Введите имя: ");
            userName= Console.ReadLine();
            Console.Write("Введите символ: ");
            userSymbol = Char.Parse(Console.ReadLine());
            userNameAndSymbols = userSymbol + userName + userSymbol;

            for (int i = 0; i < userNameAndSymbols.Length; i++) 
            {
                lineChar += userSymbol;
            }

            Console.WriteLine(lineChar);
            Console.WriteLine(userNameAndSymbols);
            Console.WriteLine(lineChar);

            Console.ReadKey();
        }
    }
}
