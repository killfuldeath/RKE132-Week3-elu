int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);  //te kindlasti arvasid et see tekst tuleb sama kui enne

switch (weekday)
{
    case 0:
        Console.WriteLine("Today is Sunday!");
        break;
    case 1:
        Console.WriteLine("Today is Monday!");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday!");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday!");
        break;
    case 4:
        Console.WriteLine("Today is Thursday!");
        break;
    case 5:
        Console.WriteLine("Today is Friday");
        break ;
    case 6:
        Console.WriteLine("Today is Saturday!");
        break;
    default:
        Console.WriteLine("Your calendar must be broken or something.");
        break;
}

Console.WriteLine("Have a nice day!");