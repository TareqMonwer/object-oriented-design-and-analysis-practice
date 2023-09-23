package dogdoor_v2;

public class Remote {
    private DoogDoor door;

    public Remote(DoogDoor door) {
        this.door = door;
    }

    public void pressButton() {
        door.open();
    }
}
