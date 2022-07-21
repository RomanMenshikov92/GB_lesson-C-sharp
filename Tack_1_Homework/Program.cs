// See https://aka.ms/new-console-template for more information
// Домашнее задание
// Задание Пример
// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3
int a, b;
Console.WriteLine("Введите два числа: ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a > b) {
    Console.WriteLine("{0} - Максимальное число", a);
    Console.WriteLine("{0} - Минимальное число", b);
}
else {
    Console.WriteLine("{0} - Максимальное число ", b);
    Console.WriteLine("{0} - Минимальное число", a);
}
Console.ReadLine();
// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
  int d,e,r;
  Console.WriteLine("Введите три числа: ");
  d = Convert.ToInt32(Console.ReadLine());
  e = Convert.ToInt32(Console.ReadLine());
  r = Convert.ToInt32(Console.ReadLine());
  if (d > e && d > r) {
      Console.WriteLine("{0} - Самое максимальное число из трех чисел", d);
  }
  else if (e > r) {
      Console.WriteLine("{0} - Самое максимальное число из трех чисел", e);
  }
  else {
      Console.WriteLine("{0} - Самое максимальное число из трех чисел", r);
  }
  Console.ReadLine();
// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4->да
// - 3->нет
// 7->нет
int q;
Console.WriteLine("Введите число: ");
q = Convert.ToInt32(Console.ReadLine());
if (q % 2 == 0) {
    Console.WriteLine("{0} - Чётное число", q);
}
else {
    Console.WriteLine("{0} - Нечётное число", q);
}
Console.ReadLine();
// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int w;
int i = 1;
Console.Write("Введите число: ");
w = Convert.ToInt32(Console.ReadLine());
while (i < w) {
    Console.WriteLine("{0} - Четные числа в диапазоне", i + 1);
    i += 2; 
}
Console.ReadLine();

Console.WriteLine("Спасибо за внимание!");
