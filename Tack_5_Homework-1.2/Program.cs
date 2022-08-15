// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int[] numbers = new int[4];

void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}
FillArrayRandomNumbers(numbers, -99, 99);

void WriteArrayToConsole(int[] array)
{
    Console.Clear();
    Console.WriteLine("Рандомный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
WriteArrayToConsole(numbers);
Console.WriteLine();

int SumElementsStandingInOddPositions(int[] array)
{
    int sumElementsPos = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
      if (array[i] < 0)
      {
        sumElementsPos = 0;
        break;
      }
      else
      {
        sumElementsPos += array[i];
      }
    }
    return sumElementsPos;
}

int sumElements = SumElementsStandingInOddPositions(numbers);
Console.WriteLine($"В данном массиве сумма элементов, стоящих на нечётных позициях равняется:{sumElements}");
Console.WriteLine();



