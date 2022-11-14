package Builder;

public class Main {
    public static void main(String[] args) {
        House house = new Building().buildHouse();

        System.out.println("==================");

        House house2 = new Building("str").buildHouse2();
    }
}
