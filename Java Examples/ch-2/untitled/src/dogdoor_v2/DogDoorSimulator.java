package dogdoor_v2;

public class DogDoorSimulator {
    public static void main(String[] args) {
        DoogDoor door = new DoogDoor();
        Bark rowlf = new Bark("rowlf");
        door.addAllowedBark(rowlf);

        Bark rooowlf = new Bark("rooowlf");
        door.addAllowedBark(rooowlf);

        Bark rawlf = new Bark("rawlf");
        door.addAllowedBark(rawlf);

        Bark woof = new Bark("woof");
        door.addAllowedBark(woof);

        BarkRecognizer recognizer = new BarkRecognizer(door);
        Remote remote = new Remote(door);

        // Simulate hardware hearing a bark
        System.out.println("Bruce starts barking.");
        recognizer.recognize(rawlf);

        if (door.isOpen()) {
            System.out.println("Bruce has gone outside");
        } else {
            System.out.println("Door failed to open, Bruce is stuck inside!");
            throw new RuntimeException("Door failed to open, Bruce is stuck inside!");
        }

        try {
            Thread.sleep(10000);
        } catch (InterruptedException e) { }

        System.out.println("\nBruce all done...");
        System.out.println("... but he's stuck outside!");

        // Simulate hardware hearing bark from neighbours dog.
        Bark yip = new Bark("yip");
        System.out.println("A small dog starts barking.");
        recognizer.recognize(yip);

        try {
            Thread.sleep(5000);
        } catch (InterruptedException e) { }

        // Simulate hardware hearing bark again.
        System.out.println("Bruce starts barking.");
        recognizer.recognize(rowlf);

        if (door.isOpen()) {
            System.out.println("Bruce is back inside.");
        } else {
            System.out.println("Door failed to open, Bruce is stuck outside!");
            throw new RuntimeException("Door failed to open, Bruce is stuck inside!");
        }
    }
}
