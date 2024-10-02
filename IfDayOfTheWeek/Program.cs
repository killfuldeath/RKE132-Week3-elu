
int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek);   //datetime on nii hästi teada igas keels

if  (weekday == 1)
{
    Console.WriteLine("Today is Monday!");
}
else if (weekday == 2)
{
    Console.WriteLine("Today is Tuesday!");
}
else if (weekday == 3)
{
    Console.WriteLine("Today is Wednesday!");
}
else if (weekday == 4)
{
    Console.WriteLine("Today is Thursday!");
}
else if (weekday == 5)
{
    Console.WriteLine("Today is Friday!");
}
else if (weekday == 0)
{
    Console.WriteLine("Today is Sunday!");
}
else
{
    Console.WriteLine("Today is Saturday.");
}

Console.WriteLine("Have a somewhat nice day!");