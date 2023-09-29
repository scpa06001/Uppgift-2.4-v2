using System;
namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad tjänar den första anställda i månaden?");
            string lön1text = Console.ReadLine();
            double lön1 = double.Parse(lön1text);
            Console.WriteLine("Vad tjänar den andra anställda i månaden?");
            string lön2text = Console.ReadLine();
            double lön2 = double.Parse(lön2text);
            Console.WriteLine("Vad tjänar den tredje anställda i månaden?");
            string lön3text = Console.ReadLine();
            double lön3 = double.Parse(lön3text);
            double medellön = (lön1 + lön2 + lön3) / 2;
            Console.WriteLine("Medellönen är " + medellön + " kr/månaden");
            Console.ReadKey();
        }
    }
}