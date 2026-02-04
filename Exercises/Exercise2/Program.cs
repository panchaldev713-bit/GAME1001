// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Let me calculte for you");
Console.WriteLine("enter the opration: + - * / %");
string userChoise = Console.ReadLine();
Console.WriteLine("Enter a number");
string number = Console.ReadLine();
int number1 = int.Parse(number);
Console.WriteLine("Enter another number");
number = Console.ReadLine();
int number2 = int.Parse(number);

if(userChoise =="+")
{
    int sum = number1 + number2;
    Console.WriteLine($"The sum of {number1} and {number2} is {sum}");
}
else if(userChoise =="-")
{
    int answer = number1 - number2;
    Console.WriteLine($"The result of {number1} and {number2} is {answer}");
    }
else if(userChoise =="*")
{
    int answer = number1 * number2;
    Console.WriteLine($"The multiplication of {number1} and {number2} is {answer}");
    }
else if(userChoise =="/")
{
    int answer = number1 / number2;
    Console.WriteLine($"The divition of {number1} and {number2} is {answer}");
    }
else if(userChoise =="%")
{
    int remainder = number1 % number2;
    int answer = number1 / number2;
    Console.WriteLine($"The divition of {number1} and {number2} is {answer} and {remainder}");
    }