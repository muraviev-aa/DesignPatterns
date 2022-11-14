package Builder;

public class Building {
    private Builder builder;
    private Builder builder2;

    public Building() {
        builder = new FirstHouse();
    }

    public Building(String s) {
        builder2 = new SecondHouse();
    }

    public House buildHouse() {
        return builder.builHouse();
    }

    public House buildHouse2() {
        return builder2.builHouse();
    }
}
