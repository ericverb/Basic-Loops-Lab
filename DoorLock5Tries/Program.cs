bool doorLocked = true;
int userAttempts = 0;

while (doorLocked)
{
    Console.WriteLine("Please enter 5 digit combination");
    int userCombination;
    bool isValid = int.TryParse(Console.ReadLine(), out userCombination);

    if (userAttempts == 4)
    {
        Console.WriteLine("Too many incorrect attempts!");
        Environment.Exit(0);
    }
    else
    {
        if (isValid)
        {
            if (userCombination == 13579)
            {
                Console.WriteLine("Welcome!");
                doorLocked = false;
                Environment.Exit(0);
            }
            else
            {
                doorLocked = true;
                userAttempts++;
            }
        }

        else
        {
            doorLocked = true;
            userAttempts++;
        }
    }
}