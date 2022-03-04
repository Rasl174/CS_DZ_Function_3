using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Function_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canExit = false;

            while (!canExit)
            {
                Console.WriteLine("Для конвертации введите 1 ");
                Console.WriteLine("Для выхода введите 2 или exit ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Введите число которое нужно сконвертировать: ");
                        Convert(out int convertedSymbol);
                        break;
                    case "2":
                    case "exit":
                        canExit = true;
                        break;
                }
                
            }
        }

        static void Convert(out int number)
        {
            string userInput = Console.ReadLine();

            bool canConvert = int.TryParse(userInput, out number);

            if (canConvert)
            {
                Console.WriteLine("Число: " + userInput + " удалось сконвертировать в: " + number);
            }
                
            else
            {
                Console.WriteLine("Ошибка конвертации.");
            }
        }
    }
}
