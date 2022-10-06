bool doorStatus = CheckCombination();

if (!doorStatus)
{
    Console.WriteLine("Too many incorrect attempts!");
    Environment.Exit(0);
}

Environment.Exit(0);


bool CheckCombination()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Please enter 5 digit combination");
        int userCombination;
        bool isValid = int.TryParse(Console.ReadLine(), out userCombination);

        if (isValid)
        {
            if (userCombination == 13579)
            {
                Console.WriteLine("Welcome!");
                return true;
            }
        }
    }

    return false;
}