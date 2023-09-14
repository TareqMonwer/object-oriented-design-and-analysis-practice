package dogdoor;

import dogdoor.dogdoor.DogDoor;
import dogdoor.remote.Remote;

public class DogDoorSimulator {
    public static void main(String[] args) {
        DogDoor door = new DogDoor();
        Remote remote = new Remote(door);
        System.out.println("Fido barks outside...");
        remote.toggleDoor();
        System.out.println("Fido entered home");
        remote.toggleDoor();

        System.out.println("\nHe's trying to go out...");
        remote.toggleDoor();
        System.out.println("Fido's gone outside...");
        remote.toggleDoor();
    }
}
