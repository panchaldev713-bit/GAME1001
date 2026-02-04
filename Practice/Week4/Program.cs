Console.WriteLine("======================");
Console.WriteLine("|| Simulator starts ||");
Console.WriteLine("======================");

Console.WriteLine("\nEnter player's health");
string healthInput = Console.ReadLine();
int health = int.Parse(healthInput);

Console.WriteLine("\nEnter damage that player hit");
string damageInput = Console.ReadLine();
int damage = int.Parse(damageInput);

Console.WriteLine("\nis the player have shild");
string userChoice = Console.ReadLine();

if (userChoice.ToLower() == "yes")
{
    Console.WriteLine($"\nplayer's health is {health}");
    Console.WriteLine("Player is safe");
}
else if (userChoice.ToLower() == "no")
{
    health = health - damage; 
    Console.WriteLine($"\nPlayer's health is {health}");
    Console.WriteLine("Players's gone hit back?");
}

Console.WriteLine("\n=========================");
Console.WriteLine("|| Simulator Ends here ||");
Console.WriteLine("=========================");