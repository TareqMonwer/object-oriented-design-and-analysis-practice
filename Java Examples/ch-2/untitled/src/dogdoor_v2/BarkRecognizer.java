package dogdoor_v2;

import java.util.List;

public class BarkRecognizer {
    private DoogDoor door;

    public BarkRecognizer(DoogDoor door) {
        this.door = door;
    }

    public void recognize(Bark bark) {
        System.out.println("\tBarkRecognizer hears a " + bark.getSound() + " sound.");

        List<Bark> allowedBarks = door.getAllowedBarks();
        for (Bark allowedBark:allowedBarks) {

            if (allowedBark.equals(bark)) {
                door.open();
                return;
            }
        }

        System.out.println("This dog is not allowed.");
    }
}
