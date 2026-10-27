class Program
{
    static void Main()
    {
        PrintTransmission("Calibration complete");
        PrintTransmission("Relay-7", "Signal acquired");
    }

    static void PrintTransmission(string message)
    {
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    static void PrintTransmission(string sender, string message)
    {
        Console.WriteLine($"{sender} {message}");
    }
}
