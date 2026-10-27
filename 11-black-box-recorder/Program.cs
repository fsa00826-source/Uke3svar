using System.IO;

string path = "blackbox.txt";

if (!File.Exists(path))
{
    File.WriteAllLines(path, new[] { "Southlunar40, sit tight!", "Descend in O X 4 seconds. ", "Put on your helmet A$AP!" });
}
foreach (var line in File.ReadAllLines(path))
{
    Console.WriteLine(line);
}