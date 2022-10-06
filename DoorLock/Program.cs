bool doorLocked = true;

while (doorLocked)
{
    Console.WriteLine("Please enter 5 digit key code!");
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
}