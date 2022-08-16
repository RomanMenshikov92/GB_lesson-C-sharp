// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write($"Каков ваш размер массива?: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void EnteringNumbers(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент c клавиатуры: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
EnteringNumbers(size);

int Check(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}
int checkout = Check(array);
Console.WriteLine($"В данном массиве мы обнаружили, что числа больше 0 равно : {checkout} ");
