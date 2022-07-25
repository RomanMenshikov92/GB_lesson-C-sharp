//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int cub;
Console.Write("Введите любое число: ");
cub = Convert.ToInt32(Console.ReadLine());

void NumbersCube(int[] cub) {
    int step;
    int length = cub.Length;
    for (step = 1; step < cub.Length; step++)
        Console.Write(step * step * step + " ");
}

int[] array = new int[cub + 1];
NumbersCube(array);
