using System;

namespace FirstProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // {тип данных для хранения} {имя переменной};
            // {тип данных для хранения} {имя переменной} = {значение переменной в соответствии её типы};

            const string somthing = "RTU MIREA";
            const string msg = "Hello";

            Console.WriteLine(msg);
            Console.WriteLine(msg + somthing);
            Console.WriteLine(msg);
            Console.WriteLine(msg);
            Console.WriteLine($"{msg} {somthing}");
            //Console.WriteLine("{msg} {somthing}");
            //Console.WriteLine("Hello  RTU MIREA");
        }
    }
}
