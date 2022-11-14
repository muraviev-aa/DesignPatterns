namespace CreationalPatterns.Builder
{
    internal class FirstHouse : Builder
    {
        public FirstHouse()
        {
            house = new House();
        }

        public override House BuildHouse()
        {
            house.BuildBase();
            house.BuildWalls();
            house.BuildFloors();
            house.BuildRoof();
            return house;
        }
    }
}
