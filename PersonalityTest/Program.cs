using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siseta oma lemmikvärv");
            string UserColor = Console.ReadLine();
            if(UserColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if(UserColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if(UserColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber");
            }
            else
            {
                Console.WriteLine($"Oled {UserColor} ükssarvik.");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
