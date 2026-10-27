List<Artifact> artifacts = new List<Artifact>()
{
    new Artifact("Helena", "Mars", 500),
    new Artifact("Olav", "Sweden", -44),
    new Artifact("Donald Trump", "Oslo", 12521),
    new Artifact("JohnnyBig", "Andromeda", 33375),
};
Console.WriteLine($"Antall:  {artifacts.Count}");

foreach (var artifact in artifacts)
{
    Console.WriteLine($"{artifact.Name} | {artifact.Origin} | Risk: {artifact.Risk}");
}

artifacts.Add(new Artifact("Plato", "Atlantis", -11000));

Console.WriteLine($"Antall etter påfyll: {artifacts.Count}");
