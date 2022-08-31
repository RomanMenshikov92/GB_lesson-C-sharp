// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


Console.Clear();
Console.WriteLine($"\nВведите размер массива: x * y * z");
Console.WriteLine("Введите x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z:");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"");

int[,,] threeDimensionalArray = new int[x, y, z];
Console.WriteLine($"\nТрёхмерный массив из неповторяющихся двузначных чисел");

void WriteArray(int[,,] threeDimensionalArray)
{
    for (int i = 0; i < threeDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDimensionalArray.GetLength(1); j++)
        {
            Console.Write($"x({i}) y({j}) ");
            for (int k = 0; k < threeDimensionalArray.GetLength(2); k++)
            {
                Console.Write($"z({k})={threeDimensionalArray[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] threeDimensionalArray)
{
    int[] temp = new int[threeDimensionalArray.GetLength(0) * threeDimensionalArray.GetLength(1) * threeDimensionalArray.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < threeDimensionalArray.GetLength(0); x++)
    {
        for (int y = 0; y < threeDimensionalArray.GetLength(1); y++)
        {
            for (int z = 0; z < threeDimensionalArray.GetLength(2); z++)
            {
                threeDimensionalArray[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

CreateArray(threeDimensionalArray);
WriteArray(threeDimensionalArray);

