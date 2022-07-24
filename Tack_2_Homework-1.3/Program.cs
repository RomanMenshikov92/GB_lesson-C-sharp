//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int dayNum;
Console.Write("Введи цифру, обозначающую день недели: ");
dayNum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNum)
{
    if (dayNum == 1) {
        Console.WriteLine("Понедельник. Это рабочий день.");
    }
    if (dayNum == 2) {
        Console.WriteLine("Вторник. Это рабочий день.");
    }
    if (dayNum == 3) {
        Console.WriteLine("Среда. Это рабочий день.");
    }
    if (dayNum == 4) {
        Console.WriteLine("Четверг. Это рабочий день.");
    }
    if (dayNum == 5) {
        Console.WriteLine("Пятница. Это рабочий день.");
    }
    if (dayNum == 6) {
        Console.WriteLine("Суббота. Это выходной день.");
    }
    if (dayNum == 7) {
        Console.WriteLine("Воскресенье. Это выходной день.");
    }
    else if (dayNum < 1 || dayNum > 7) {
        Console.WriteLine("Это не день недели");
    }
}

CheckingTheDayOfTheWeek(dayNum);
