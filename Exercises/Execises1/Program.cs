// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Hey, what's your name?");
string name = Console.ReadLine();
Console.WriteLine("How old are you?");
string answer = Console.ReadLine();
int age = int.Parse(answer);
Console.WriteLine($"OH, Your name is {name} and your are {age} years old.");