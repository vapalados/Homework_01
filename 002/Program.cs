﻿//Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число!");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число!");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число!");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Имеем три числа {a}, {b} и {c}!");

int max = a;

if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;

Console.Write("Максимальное = ");
Console.WriteLine(max);