package dogdoor;

import dogdoor.bark.Bark;
import dogdoor.barkrecognizer.BarkRecognizer;
import dogdoor.dogdoor.DogDoor;
import dogdoor.remote.Remote;

public class DogDoorSimulator {
    public static void main(String[] args) {
        DogDoor door = new DogDoor();
        Remote remote = new Remote(door);
        BarkRecognizer recognizer = new BarkRecognizer(door);
        Bark woof = new Bark("woof");
        Bark ruff = new Bark("ruff");
        Bark pipip = new Bark("pipip");

        door.addAllowedBark(woof);

        System.out.println("Fido trying to go out...");
        // remote.toggleDoor();
        recognizer.recognize(woof);
        System.out.println("Fido's gone outside...");
        System.out.println("Fido's all done...");

        try {
            Thread.sleep(10000);
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }

        System.out.println("But fido's stuck outside\n");
        System.out.println("Fido starts barking to get inside...");
//        System.out.println("\n... So gina grabs the remote control");
//        remote.toggleDoor();
//        recognizer.recognize(woof);
        recognizer.recognize(ruff);
        System.out.println("Back inside...");
    }
}
