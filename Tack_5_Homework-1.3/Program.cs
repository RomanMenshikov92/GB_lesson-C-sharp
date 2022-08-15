// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
double[] numbers = new double[5];

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
FillArrayRandomNumbers(numbers);

void WriteArrayToConsole(double[] numbers)
{
    Console.WriteLine("Рандомный массив из вещественных чисел:");
    Console.Write("[  ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.Write("]");
    Console.WriteLine();
}
WriteArrayToConsole(numbers);
Console.WriteLine();

void FindingMaxMinAndDifferenceBetweenThem(double [] numbers)
{
    double max = numbers[0];
    double min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (max < numbers[i])
        {
            max = numbers[i];
        }
        if (min > numbers[i])
        {
            min = numbers[i];
        }
    }
    double decision = max - min;
    Console.WriteLine($"Разница между максимальным ({max}) и минимальным({min}) элементами: {decision}");
    Console.WriteLine();
}
FindingMaxMinAndDifferenceBetweenThem(numbers);

