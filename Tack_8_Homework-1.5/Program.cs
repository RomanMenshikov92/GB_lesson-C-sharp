// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int n = 4;
int[,] spiralArrayMatrix = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;

void Matrix(int[,] spiralArrayMatrix)
{
    while (temp <= spiralArrayMatrix.GetLength(0) * spiralArrayMatrix.GetLength(1))
    {
        spiralArrayMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < spiralArrayMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralArrayMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralArrayMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Cпирально массив 4 на 4: ");
Console.WriteLine();
Matrix(spiralArrayMatrix);
WriteArray(spiralArrayMatrix);
Console.WriteLine();
