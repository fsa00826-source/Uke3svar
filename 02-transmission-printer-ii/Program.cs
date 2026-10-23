class Program
{
    static void Main()
    {
        PrintTransmission("System ready");
        PrintTransmission("Dock", "Gate unlocked");
        PrintTransmission("Hei", "hei2", 5900);
        // TODO: Kall også din tredje overload.
    }

    static void PrintTransmission(string message)
    {
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    static void PrintTransmission(string sender, string message)
    {
        Console.WriteLine($"[{sender}] {message}");
    }

    static void PrintTransmission(string sender, string message, int explosive)
    {
        Console.WriteLine($"[{sender}] {message} {explosive}");
    }

    // TODO: Lag tredje overload.
}
