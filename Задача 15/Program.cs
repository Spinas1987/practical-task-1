// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool IsWeekend(int weekday)
{
    if (weekday > 5)
    {
        return true;
    }
    return false;
}

bool ValidDayWeek(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}


Console.WriteLine("ВВедите день недели");
int weekday = Convert.ToInt32(Console.ReadLine());

if (ValidDayWeek(weekday))
{
    if (IsWeekend(weekday))
    {
        Console.WriteLine("Наконец выходной!");
    }
    else
    {
        Console.WriteLine("Придется поработать!");
    }
}