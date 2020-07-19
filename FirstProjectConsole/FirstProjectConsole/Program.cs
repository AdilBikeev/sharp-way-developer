using System;

namespace FirstProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            if (int.TryParse(Console.ReadLine(), out int firstNum))
            {
                if (int.TryParse(Console.ReadLine(), out int secondNum))
                {   
                    Console.WriteLine($"Ваши числа: {firstNum} и {secondNum}");
                }
                else
                {
                    Console.WriteLine("Вы неверно ввели 2-ое число");
                }
            }
            else
            {
                Console.WriteLine("Вы неверно ввели 1-ое число");
            }
            */

            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num > 0)
                {
                  Console.WriteLine("Введенное число - положительное");
                }
                else if (num == 0)
                {
                    Console.WriteLine("Введенное число == 0");
                }
                else
                {
                    Console.WriteLine("Введенное число - отрицательное");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели неверное число");
            }
        }
    }
}
