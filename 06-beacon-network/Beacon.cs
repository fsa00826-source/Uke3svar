public class Beacon
{
    public int Frequency { get; set; }

    // ^__^ koden over er ikke "static"
    // fordi det ville gitt samme verdi til alle beacons-ene
    // og overskrive den forrige verdien

    public static int CreatedCount { get; private set; }

    public Beacon(int frequency)
    {
        Frequency = frequency;

        CreatedCount++;

        // TODO: Oppdater CreatedCount.
    }
}
