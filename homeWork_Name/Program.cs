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
            int stringLongh;

            Console.Write("Введите имя: ");
            userName= Console.ReadLine();
            Console.Write("Введите символ: ");
            userSymbol = Char.Parse(Console.ReadLine());
            stringLongh = userName.Length;

            for (int i = 0; i < stringLongh; i++) 
            {
                Console.Write($"{userSymbol} ");
            }

            Console.WriteLine();
            Console.WriteLine($"{userSymbol} {userName} {userSymbol}");

            for (int i = 0; i < stringLongh; i++)
            {
                Console.Write($"{userSymbol} ");
            }

            Console.ReadKey();
        }
    }
}
