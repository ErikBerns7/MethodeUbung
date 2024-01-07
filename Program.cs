int number = AskForNumberInRange("Enter a number from 0 to 100", 0, 100);


while (true) {
    int hunterNumber = AskForNumber("Enter a number from 0 to 100");
    if (number == hunterNumber)
    {
        Console.WriteLine("You got it!");
        break;
    }
    else if (number > hunterNumber)
    {
        Console.WriteLine("too low, try again.");
        continue;
    }
    else if (number < hunterNumber)
    {
        Console.WriteLine("too high, try again.");
        continue;
    }
}

int AskForNumber(string text)
{
    Console.WriteLine($"{text}");
    string numberText = Console.ReadLine();
    int numberHunter = Convert.ToInt32(numberText);
    return numberHunter;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        Console.WriteLine($"{text}");
        string numberText = Console.ReadLine();
        int number = Convert.ToInt32(numberText);

        if (number < min)
        {
            Console.WriteLine("The number is too low.");
            continue;
        }
        else if (number > max)
        {
            Console.WriteLine("The number is too high.");
            continue;
        }
        else
        {
            return number;
            
        }
    }
    
    
    

}