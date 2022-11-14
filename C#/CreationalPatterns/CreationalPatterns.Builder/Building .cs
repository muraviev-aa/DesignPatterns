using System;

namespace CreationalPatterns.Builder
{
    internal class Building
    {
        private readonly Builder builder;
        private readonly Builder builder2;

        public Building()
        {
            builder = new FirstHouse();
        }

        public Building(String s)
        {
            builder2 = new SecondHouse();
        }

        public House BuildHouse()
        {
            return builder.BuildHouse();
        }

        public House BuildHouse2()
        {
            return builder2.BuildHouse();
        }
    }
}
