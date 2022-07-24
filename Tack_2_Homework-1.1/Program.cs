// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456-> 5
//782-> 8
//918-> 1
int threeDigitNumber;
string stringIndex;

Console.WriteLine("Введи трёхзначное число: ");
threeDigitNumber = Convert.ToInt32(Console.ReadLine());
stringIndex = Convert.ToString(threeDigitNumber);
    if (threeDigitNumber < 999) {
        Console.WriteLine("Вторая цифра этого числа -> " + stringIndex[1]);
    }
    else {
        Console.WriteLine("Это не трехзначное число");
    }
Console.ReadLine();

