// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int SumNumN(int numN)
{
    int result = 0;

    for (int i = 0; i < numN; i++)
    {
        result = result + numN % 10;
        numN = numN / 10;
    }
    return result;
}

int sumNumN = SumNumN(numN);
Console.WriteLine("Сумма цифр в числе: " + sumNumN);
