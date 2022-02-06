using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma tulemus");
            char UserResult = Convert.ToChar(Console.ReadLine().ToUpper());
            if(UserResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if(UserResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if(UserResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if(UserResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }
            else if(UserResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if(UserResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }
            else
            {
                Console.WriteLine("Vale väärtus.");
            }
        }
    }
}
