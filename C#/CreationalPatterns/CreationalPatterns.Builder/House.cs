using System;

namespace CreationalPatterns.Builder
{
    internal class House
    {
        public void BuildBase()
        {
            Console.WriteLine("Base is building...");
        }

        public void BuildWalls()
        {
            Console.WriteLine("Walls are building...");
        }

        public void BuildFloors()
        {
            Console.WriteLine("Floors are building...");
        }

        public void BuildRoof()
        {
            Console.WriteLine("Roof is building...");
        }
    }
}
