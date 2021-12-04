using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение (слова разделять пробелами, знаки препинания не использовать).");
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string maxLength = string.Empty;
            for(int i=0;i<stringArray.Length;i++)
            {
                if (stringArray[i].Length > maxLength.Length)
                    maxLength = stringArray[i];
            }
            Console.WriteLine("Наибольшее слово в веденном предложении \"{0}\".",maxLength);
            Console.ReadKey();
        }
    }
}
