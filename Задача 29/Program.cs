// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GeneratArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");

}

Console.WriteLine("Введите длины массива");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начала диапозона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец диапозона");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = GeneratArray(length, min, max);
PrintArray(array);
