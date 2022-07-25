﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53
int x1 ,y1, z1;
int x2 ,y2, z2;
x1 = coordinates("x", "A");
y1 = coordinates("y", "A");
z1 = coordinates("z", "A");
x2 = coordinates("x", "B");
y2 = coordinates("y", "B");
z2 = coordinates("z", "B");

int coordinates(string xyz, string AB) {
    Console.Write($"Введите любую координату {xyz} точки {AB}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double formula(double x1, double x2, double y1, double y2, double z1, double z2) {
  return Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)); // возвращает квадратный корень числа
}

double lengthOfTheSegment =  Math.Round (formula(x1, x2, y1, y2, z1, z2), 2 ); // возвращает число, округленное к ближайшему целому

Console.WriteLine($"Длина отрезка: {lengthOfTheSegment}");

