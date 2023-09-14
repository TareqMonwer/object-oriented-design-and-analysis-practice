package dogdoor.remote;

import dogdoor.dogdoor.DogDoor;

public class Remote {
    private final DogDoor door;

    public Remote(DogDoor door) {
        this.door = door;
    }

    public void toggleDoor() {
        System.out.println("Pressing the remote button...");
        if (door.isOpen()) {
            door.close();
        } else {
            door.open();
        }
    }
}
