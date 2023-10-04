// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Degree(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res *= a;
    }
    return res;
}


Console.WriteLine("Вводите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводите число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int result = Degree(number1, number2);
if (number2 < 0)
{
    Console.Write("Число B должно быть натуральным ");
}
else 
{
Console.WriteLine($"Число {number1} в натуральной степени {number2} =  {result}");
}


