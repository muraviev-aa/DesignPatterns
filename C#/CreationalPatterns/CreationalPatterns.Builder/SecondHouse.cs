namespace CreationalPatterns.Builder
{
    internal class SecondHouse:Builder
    {
        public SecondHouse()
        {
            house = new House();
        }

        public override House BuildHouse()
        {
            house.BuildBase();
            house.BuildWalls();
            house.BuildRoof();
            return house;
        }
    }
}
