bool doorLocked = true;
int userAttempts = 0;

do
{
    if (userAttempts == 5)
    {
        Console.WriteLine("Too many incorrect attempts!");
        Environment.Exit(0);
    }
    else
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
} while (doorLocked);