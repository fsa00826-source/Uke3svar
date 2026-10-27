public class Creature
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Energy { get; set; }

    public Creature(string name, string species, int energy)
    {
        Name = name;
        Species = species;
        Energy = energy;
    }
    public string TilFilLinje()
    {
        return $"{Name}|{Species}|{Energy}";
    }
}
