// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Let me calculte for you");
Console.WriteLine("Enter a number");
string number = Console.ReadLine();
int number1 = int.Parse(number);
Console.WriteLine("Enter another number");
number = Console.ReadLine();
int number2 = int.Parse(number);
int sum = number1 + number2;
Console.WriteLine($"The sum of {number1} and {number2} is {sum}");