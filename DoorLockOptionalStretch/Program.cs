
bool doorStatus = CheckCombination();

if (!doorStatus)
{
    Console.WriteLine("Too many incorrect attempts!");
    Environment.Exit(0);

}
Console.WriteLine("Welcome!");
Environment.Exit(0);







bool CheckCombination()
{
    for (int i = 0; i <= 4; i++)
    {
        Console.WriteLine("Please enter 5 digit combination");
        int userCombination;
        bool isValid = int.TryParse(Console.ReadLine(), out userCombination);

        if (i == 4)
        {
            return false;
        }

        if (isValid)
        {
            if (userCombination == 13579)
            {
                return true;
            }

        }
        
    }
   
    return false;

}
