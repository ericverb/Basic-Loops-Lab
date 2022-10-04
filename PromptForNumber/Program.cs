bool runAgain = true;

while (runAgain)
{
    Console.WriteLine("Please Enter a number!");
    int userNumber;
    bool isValid = int.TryParse(Console.ReadLine(), out userNumber);
    if (isValid)
    {
        for (int i = userNumber; i >= 0; i--)
        {
            Console.WriteLine($"{Environment.NewLine}{i}");
        }

        for (int i = 0; i <= userNumber; i++)
        {
            Console.WriteLine($"{Environment.NewLine}{i}");
        }

        Console.WriteLine("Would you like to continue (y/n)?");
        string continueYn  = Console.ReadLine()!.ToLower();
        if (continueYn.Trim() != "y")
        {
            runAgain = false;
            ExitApplication();

        }


    }

    else
    {
        runAgain = false;
        ExitApplication();
    }
}

void ExitApplication()
{
    Console.WriteLine("Goodbye!");
    Environment.Exit(0);
}