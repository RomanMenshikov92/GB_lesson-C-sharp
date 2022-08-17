// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];

void GetMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
GetMatrix(numbers);
Console.WriteLine();

void PrintArray(int[,] array)
{
    Console.WriteLine("Рандомный массив двумерного массива из целых чисел:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
PrintArray(numbers);
Console.WriteLine();

void FindAverageNumber(int[,] numbers)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            average = (average + numbers[i, j]);
        }
        average = average / n;
        Console.Write(average + "; ");
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое число элементов каждого столбца равняются: ");
FindAverageNumber(numbers);
Console.WriteLine();