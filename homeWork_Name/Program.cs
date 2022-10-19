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
            int addChar = 2;

            Console.Write("Введите имя: ");
            userName= Console.ReadLine();
            Console.Write("Введите символ: ");
            userSymbol = Char.Parse(Console.ReadLine());

            for (int i = 0; i < userName.Length + addChar; i++) 
            {
                lineChar += userSymbol;
            }

            Console.WriteLine(lineChar);
            Console.WriteLine(userSymbol + userName + userSymbol);
            Console.WriteLine(lineChar);

            Console.ReadKey();
        }
    }
}
