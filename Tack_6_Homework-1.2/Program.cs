// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.Clear();
double[ , ] arr = new double[2 , 2];
double[] point = new double[2];

void EnteringNumbersInAnArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Введите числа {i + 1}-го уравнения:\n");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите - k{j + 1}: ");
            else Console.Write($"Введите - b{i + 1}: ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
EnteringNumbersInAnArray();

double[] Equation(double[ , ] arr)
{
    point[0] = (arr[1, 1] - arr[0, 1]) / (arr[0, 0] - arr[1, 0]);
    point[1] = point[0] * arr[0, 0] + arr[0, 1];
    return point;
}
Equation(arr);

Console.WriteLine($"Мы получили точки пересечения прямых: ({point[0]}; {point[1]})");

