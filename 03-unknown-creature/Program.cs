Creature first = new Creature();
Creature second = new Creature();
Creature third = new Creature();

first.Name = "Rolf Egil";
first.Species = "Human male";
first.Energy = 420;

second.Name = "Lars Magne";
second.Species = "Ultimate God";
second.Energy = 300;

third.Name = "Tobias";
third.Species = "Regular God";
third.Energy = 9000;

Console.WriteLine($"{first.Name} | {first.Species} | Energy: {first.Energy}");
Console.WriteLine($"{second.Name} | {second.Species} | Energy: {second.Energy}");
Console.WriteLine($"{third.Name} | {third.Species} | Energy: {third.Energy}");
