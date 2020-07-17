using System;

namespace FirstProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine("\n" + symbol);

            Console.Write("Введите строку: ");
            string messsage = Console.ReadLine();
            Console.WriteLine($"Вы ввели строку: {messsage}");
        }
    }
}
