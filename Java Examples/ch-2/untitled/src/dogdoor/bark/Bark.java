package dogdoor.bark;

public class Bark {
    private String sound;

    public Bark(String sound) {
        this.sound = sound;
    }

    public String getSound() {
        return sound;
    }

    private boolean equals(Bark bark) {
        return sound.equalsIgnoreCase(bark.getSound());
    }
}
