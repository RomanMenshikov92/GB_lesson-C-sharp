// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645-> 5
//78->третьей цифры нет
//32679 -> 6
int num;
string stringIndex;

Console.Write("Введите любое число: ");
num = Convert.ToInt32(Console.ReadLine());
stringIndex = Convert.ToString(num);
    if (stringIndex.Length > 2) {
        Console.WriteLine("третья цифра -> " + stringIndex[2]); 
    }
    else {
        Console.WriteLine("-> третьей цифры нет");
    }
Console.ReadLine();