// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Задайте размер матрицы: ");
int sizeMatrix = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[sizeMatrix, sizeMatrix];
FillArrayRandomNumbers(matrixA);
int[,] matrixB = new int[sizeMatrix, sizeMatrix];
FillArrayRandomNumbers(matrixB);

int[,] matrixC = new int[sizeMatrix, sizeMatrix];

void MatrixСomposition(int[,] matrixC)
{
    for (int i = 0; i < sizeMatrix; i++)
    {
        for (int j = 0; j < sizeMatrix; j++)
        {
            for (int k = 0; k < sizeMatrix; k++)
            {
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
}
MatrixСomposition(matrixC);


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
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


Console.WriteLine("Первая матрица:");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц:");
PrintArray(matrixC);
Console.WriteLine();

