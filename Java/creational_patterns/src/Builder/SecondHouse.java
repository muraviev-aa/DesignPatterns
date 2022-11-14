package Builder;

public class SecondHouse extends Builder {
    public SecondHouse() {
        house = new House();
    }

    @Override
    public House builHouse() {
        house.buildBase();
        house.buildWalls();
        house.buildRoof();
        return house;
    }
}
