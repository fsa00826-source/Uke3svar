using System.IO;

string path = "creatures.txt";

List<Creature> creatures = new List<Creature>
{
    new Creature("Mora", "Lumen Fox", 72),
    new Creature("Kip", "Dust Eel", 18),
    new Creature("Senn", "Cloud Moth", 41)
};

List<string> linjer = new List<string>();
foreach (Creature c in creatures)
{
    linjer.Add(c.TilFilLinje());
}
File.WriteAllLines(path, linjer);

string[] lines = File.ReadAllLines(path);

List<Creature> loaded = new List<Creature>();

foreach (string line in lines)
{
    string[] parts = line.Split('|');

    if (parts.Length != 3)
    {
        continue;
    }
    if (!int.TryParse(parts[2], out int energy))
    {
        continue;
    }
    loaded.Add(new Creature(parts[0], parts[1], energy));
}
foreach(Creature c in loaded)
{
    Console.WriteLine($"{c.Name} | {c.Species} | {c.Energy}");
}

