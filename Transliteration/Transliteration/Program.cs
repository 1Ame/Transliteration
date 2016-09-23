using System;
using System.Text;
using TransliterationLib;

namespace Transliteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            do
            {
                Console.Write("\nВведіть текст для транслітерації: ");

                string input = Console.ReadLine();

                Console.WriteLine("Результат: {0} \nБажаєте продовжити (Т/Н)? ", 
                    Transliterator.GetTransliteration(input, Language.Ukrainian));                
            }
            while (Console.ReadKey().Key == ConsoleKey.N ); //english 'N' button = Ukrainian 'T' button            
        }
    }
}
