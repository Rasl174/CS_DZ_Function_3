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
            int transformNumber = 0;

            transformNumber = TransformNumber(transformNumber);

            Console.WriteLine("Вернулось число: " + transformNumber);
        }

        static int TransformNumber(int number)
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
                    break;
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
