package dogdoor_v2;

public class Bark {
    private String sound;

    public Bark(String sound) {
        this.sound = sound;
    }

    public String getSound() {
        return sound;
    }

    public boolean equals(Bark incomingBark) {
        return incomingBark.getSound().equals(getSound());
    }
}
