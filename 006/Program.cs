﻿//Программа, которая на вход принимает одно число (N), а на выходе показывает всецелые числа в промежутке от -N до N.
Console.WriteLine("Введите число до которого нужно узнать все целые числа: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Имеем число {n}!");
    
    Console.Write($"Следующие числа являются целыми: ");


for (int i = -n; i <= n; i++)
    if (i % 1 == 0)
        Console.Write($" {i}. ");