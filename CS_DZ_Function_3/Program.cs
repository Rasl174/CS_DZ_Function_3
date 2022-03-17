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
            int readNumber = 0;

            readNumber = GetNumber(readNumber);

            Console.WriteLine("Вернулось число: " + readNumber);
        }

        static int GetNumber(int number)
        {
            bool isCanTransformed = true;
            Console.WriteLine("Введите строку для преобразования: ");

            while (isCanTransformed)
            {
                string userInput = Console.ReadLine();
                bool canTransform = int.TryParse(userInput, out number);

                if (canTransform)
                {
                    Console.WriteLine("Строку: " + userInput + " удалось преобразовать.");
                    isCanTransformed = false;
                }
                else
                {
                    Console.WriteLine("Ошибка преобразования.\nВведите другую строку: ");
                }
            }
            return number;
        }
    }
}
