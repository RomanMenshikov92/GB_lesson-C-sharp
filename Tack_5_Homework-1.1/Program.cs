// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = new int[4];

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
FillArrayRandomNumbers(numbers, 100, 999);

void WriteArrayToConsole(int[] array)
{
    Console.Clear();
    Console.WriteLine("Рандомный массив из трехзначных чисел:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
WriteArrayToConsole(numbers);
Console.WriteLine();

int NumberPositiveElements(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            quantity++;
        }
    }
    return quantity;
}

int quantity = NumberPositiveElements(numbers);
Console.WriteLine($"В данном массиве обнаружено {quantity} положительных трехзначных чисел");
Console.WriteLine();