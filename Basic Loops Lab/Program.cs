bool playAgain;

do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string userResponse = Console.ReadLine()!;


    switch (userResponse.ToLower().Trim())
    {
        case "y":
            playAgain = true;
            break;
        default:
            playAgain = false;
            break;
    }
} while (playAgain);

ExitApplication();


void ExitApplication()
{
    Console.WriteLine("Goodbye!");
    Environment.Exit(0);
}