List<Artifact> artifacts = new List<Artifact>()
{
    new Artifact("Helena", "Mars", 500),
    new Artifact("Olav", "Sweden", -44),
    new Artifact("Donald Trump", "Oslo", 12521),
};
Console.WriteLine("Antall: " {artifacts.Count});

foreach (var artifact in artifacts)
{
    Console.WriteLine(artifact);
}

artifacts.Add(new Artifact("AAA", "Underground base", 50));
Console.WriteLine(artifacts.Count);

// TODO: Opprett minst fire Artifact-objekter og legg dem i listen.
// TODO: Skriv Count og alle objektene.
// TODO: Legg til ett ekstra objekt og skriv Count igjen.
