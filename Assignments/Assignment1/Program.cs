Console.WriteLine("======Score calculator======/n");
string userEnterystring;
do
{
Console.Write("enter score:");
userEnterystring = Console.ReadLine();
int numPlayers = int.Parse(userEnterystring);
int playerIndex = 1;
int highestscore = 0;
int totalScore = 0;

while(playerIndex <= numPlayers)
    {
        Console.Write($"enter player {playerIndex}'s score:");
        userEnterystring = Console.ReadLine();
        int scoreEntered = int.Parse(userEnterystring);
        totalScore += scoreEntered;
        if(scoreEntered > highestscore);
        {
        highestscore = scoreEntered;
        }
        playerIndex++;
    }
    Console.WriteLine($"toatal score: {totalScore}");
    Console.WriteLine($"Highest score: {highestscore}");
    Console.WriteLine($"Lowest score: {highestscore}");
    Console.WriteLine($"avrage score: {(float)totalScore / numPlayers}");

    Console.WriteLine("thank you for using");
    Console.Write("would you like to restart? y/n:");
    userEnterystring = Console.ReadLine();

}while(userEnterystring ==  "Y" || userEnterystring ==  "y");
