package Builder;

public class FirstHouse extends Builder {
    public FirstHouse() {
        house = new House();
    }

    @Override
    public House builHouse() {
        house.buildBase();
        house.buildWalls();
        house.buildFloors();
        house.buildRoof();
        return house;
    }
}
