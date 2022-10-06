bool doorLocked = true;
int userAttempts = 1;

while (userAttempts <= 5)
{
    Console.WriteLine("Please enter 5 digit combination");
    int userCombination;
    bool isValid = int.TryParse(Console.ReadLine(), out userCombination);
    if (isValid)
    {
        if (userCombination == 13579)
        {
            Console.WriteLine("Welcome!");
            doorLocked = false;
            Environment.Exit(0);
        }
    }

    userAttempts++;
}

Console.WriteLine("Too many incorrect attempts!");
Environment.Exit(0);