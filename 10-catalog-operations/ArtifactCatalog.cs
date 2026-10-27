using System.Data.Common;

public class ArtifactCatalog
{
    private List<Artifact> artifacts = new List<Artifact>();

    public void Add(Artifact artifact)
    {
        artifacts.Add(artifact);
    }

    public void PrintAll()
    {
        foreach(Artifact artifact in artifacts)
        {
            Console.WriteLine($"{artifact.Name} | ({artifact.Origin})");
        }
    }

    public Artifact? FindByName(string name)
    {
        foreach (Artifact artifact in artifacts)
        {
            if(artifact.Name == name)
            {
                return artifact;
            }
        }
        return null;
    }
}
