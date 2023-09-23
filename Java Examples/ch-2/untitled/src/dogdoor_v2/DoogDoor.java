package dogdoor_v2;

import java.util.ArrayList;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;

public class DoogDoor {
    private boolean open;
    private ArrayList<Bark> allowedBarks = new ArrayList<>();;



    public boolean isOpen() {
        return open;
    }

    public void close() {
        open = false;
    }

    public void open() {
        System.out.println("The door opens");
        open = true;

        final Timer timer = new Timer();
        timer.schedule(new TimerTask() {
            public void run() {
                close();
                timer.cancel();
                System.out.println("Door closes.");
            }
        }, 5000);
    }

    public ArrayList<Bark> getAllowedBarks() {
        return allowedBarks;
    }

    public void addAllowedBark(Bark allowedBark) {
        allowedBarks.add(allowedBark);
    }
}
