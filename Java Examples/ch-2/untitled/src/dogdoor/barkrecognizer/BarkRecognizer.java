package dogdoor.barkrecognizer;

import dogdoor.dogdoor.DogDoor;

public class BarkRecognizer {
    private DogDoor door;

    public BarkRecognizer(DogDoor door) {
        this.door = door;
    }

    public void recognize(String bark) {
        System.out.println("BarkRecognizer heard a " + bark + " sound...");
        door.open();
    }
}
