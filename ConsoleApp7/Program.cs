using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Володин";
            string surname = "Артур";
            string nickname;

            Console.WriteLine(name + " " + surname);

            nickname = name;
            name = surname;
            surname = nickname;

            Console.WriteLine(name + " " + surname);
        }
    }
}
