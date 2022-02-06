using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma lemmikvärv");
            string UserColor = Console.ReadLine().ToLower();
            switch (UserColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {UserColor} ükssarvik.");
                    break;
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
