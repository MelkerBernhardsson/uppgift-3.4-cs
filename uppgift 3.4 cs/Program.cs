using System;

namespace uppgift34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många minuter lång är din låt??");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("hur många sekunder?");
            int sec = int.Parse(Console.ReadLine());

            if (min <= 2 && sec < 45)
                Console.WriteLine("din låt är för kort");
            else if (min > 4 && sec > 20)
                Console.WriteLine("din låt är för lång");
            else
            Console.WriteLine("din låt är bra längd för radio");
        }
    }
}
