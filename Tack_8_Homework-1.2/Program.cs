// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк в массиве");
int numberOfRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[numberOfRows, numberOfColumns];

FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Введенный рандомный двумерный массив");
PrintArray(numbers);

int SumLineElements(int[,] numbers, int i)
{
    int sumLine = numbers[i, 0];
    for (int j = 1; j < numbers.GetLength(1); j++)
    {
        sumLine += numbers[i, j];
    }
    return sumLine;
}

int minSumLine = 0;
int sumLine = SumLineElements(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(numbers, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"Строкa № {minSumLine + 1} с наименьшей суммой элементов, которая равняется {sumLine}");
Console.WriteLine();

void FillArrayRandomNumbers(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 5);
        }
    }
}

void PrintArray(int[,] array)
{
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
