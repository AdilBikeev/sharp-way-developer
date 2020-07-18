using System;

namespace FirstProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Пожалуйста введите число: ");
            int first;
            int.TryParse(Console.ReadLine(), out first);
            Console.WriteLine("Вы ввели число: " + first);

            Console.Write("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine("\n" + symbol);

            Console.Write("Введите строку: ");
            string messsage = Console.ReadLine();
            Console.WriteLine($"Вы ввели строку: {messsage}");
        }
    }
}
