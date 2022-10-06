Console.WriteLine("Hello, World!");

bool playAgain = false;

do
{
    Console.WriteLine("Would you like to continue (y/n)?");
    string userResponse = Console.ReadLine()!;


    if (userResponse.ToLower().Trim() == "y")
    {
        Console.WriteLine("Hello, World!");
        playAgain = true;
    }
    else
    {
        ExitApplication();
    }
} while (playAgain);

Console.WriteLine("Goodbye!");

void ExitApplication()
{
    Console.WriteLine("Goodbye!");
    Environment.Exit(0);
}