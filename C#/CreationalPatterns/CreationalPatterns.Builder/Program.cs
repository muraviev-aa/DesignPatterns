using System;

namespace CreationalPatterns.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new Building().BuildHouse();

            Console.WriteLine("====================");

            House house2 = new Building("str").BuildHouse2();

            Console.ReadLine();
        }
    }
}
