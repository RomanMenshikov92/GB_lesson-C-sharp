// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.WriteLine("Введите два положительные значения: M и N.");
Console.WriteLine("Введите значение M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите значение N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int FunctionAkkerman(int M, int N)
{
    if (M == 0)
        return N + 1;
    if (M > 0 && N == 0)
        return FunctionAkkerman(M - 1, 1);
    else
        return FunctionAkkerman(M - 1, FunctionAkkerman(M, N - 1));
}

Console.WriteLine($"Функция Аккермана гласит: A({M}, {N}) = {FunctionAkkerman(M, N)}");
Console.WriteLine();