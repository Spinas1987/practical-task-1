﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



int GetThirdDigit(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

bool Validnumber(int num)
{
    if (num < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (Validnumber(number))
{
    Console.WriteLine(GetThirdDigit(number));
}

