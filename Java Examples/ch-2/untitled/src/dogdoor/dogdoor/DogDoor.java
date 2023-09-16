package dogdoor.dogdoor;

import java.util.Timer;
import java.util.TimerTask;

public class DogDoor {
    private boolean open;

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
}
