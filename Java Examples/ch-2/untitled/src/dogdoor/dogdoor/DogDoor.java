package dogdoor.dogdoor;

import dogdoor.bark.Bark;

import java.util.*;
import java.util.Timer;
import java.util.TimerTask;

public class DogDoor {
    private boolean open;
    private List<Bark> allowedBarks = new ArrayList<Bark>();


    public void open() {
        System.out.println("The door is opening");
        open = true;

        final Timer timer = new Timer();
        timer.schedule(new TimerTask() {
            public void run() {
                close();
                timer.cancel();
            }
        }, 5000);
    }

    public void close() {
        System.out.println("The door is closing");
        open = false;
    }

    public boolean isOpen() {
        return open;
    }

    public void addAllowedBark(Bark bark) {
        allowedBarks.add(bark);
    }

    public List<Bark> getAllowedBarks() {
        return allowedBarks;
    }
}
