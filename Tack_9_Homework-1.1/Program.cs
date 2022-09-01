// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите натуральное значение N от 1:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void PrintNumber(int N)
{
    if (N < 0) Console.Write($"{N} не натуральное число");
    if (N == 0) return;
    Console.Write("{0,4}", N);
    PrintNumber(N - 1);
}

Console.WriteLine("Выведены натуральные числа: ");
PrintNumber(N);
