public class Drone
{
    public string Name { get; set; }
    public int FlightHours { get; set; }

    public Drone(string name, int flightHours)
    {
        Name = name;
        FlightHours = flightHours;
    }

    public string Describe()
    {
        // TODO
        return $"Drone Name: {Name}. Flighthours: {FlightHours}.";
    }

    public bool NeedsService()
    {
        if (FlightHours >= 100)
        {
            return true;
        }
        // TODO
        return false;
    }
}
