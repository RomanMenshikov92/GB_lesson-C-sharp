// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
// псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] numbers = GetRandomArray(8);

int[] GetRandomArray(int arrayLength)
{
    int[] arr = new int[arrayLength];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 99);
    }
    return arr;
}

void WriteRandomArrayToConsole(int[] numbers)
{   
    Console.Clear();
    Console.Write("Массив: [");
    for (int i = 0; i < numbers.Length; i++)
    {   
        Console.Write(numbers[i]);
        if (i != numbers.Length - 1)
            Console.Write(",");
    }
    Console.WriteLine("]");
}

WriteRandomArrayToConsole(numbers);
