// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Вводите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число");
    return;
}


Console.WriteLine($"Введенное число: -> {number}");
int secendDigit = number /10 %10;
Console.WriteLine($"Вторая цифра число: -> {secendDigit}");
