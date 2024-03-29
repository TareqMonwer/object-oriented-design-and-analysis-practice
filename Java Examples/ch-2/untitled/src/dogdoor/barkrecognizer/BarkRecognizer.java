package dogdoor.barkrecognizer;

import dogdoor.bark.Bark;
import dogdoor.dogdoor.DogDoor;

import java.util.List;

public class BarkRecognizer {
    private final DogDoor door;

    public BarkRecognizer(DogDoor door) {
        this.door = door;
    }

    public void recognize(Bark bark) {
        List<Bark> allowedBarks = door.getAllowedBarks();
        for (Bark allowedBark:allowedBarks) {
            System.out.println("BarkRecognizer heard a " + bark.getSound() + " sound...");

            if (allowedBark.equals(bark)) {
                door.open();
                return;
            }
        }
    }
}
