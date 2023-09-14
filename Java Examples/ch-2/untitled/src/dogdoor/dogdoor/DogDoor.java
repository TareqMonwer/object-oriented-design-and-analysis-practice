package dogdoor.dogdoor;

public class DogDoor {
    private boolean open;

    public void open() {
        System.out.println("The door is opening");
        open = true;
    }

    public void close() {
        System.out.println("The door is closing");
        open = false;
    }

    public boolean isOpen() {
        return open;
    }
}
