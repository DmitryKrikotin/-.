﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Программа выводит все натуральные числа от N до 1");
Console.Write("Введите число N ");
int n=Convert.ToInt32(Console.ReadLine());
int count=n;
int num (int count)
{
    Console.Write($"{count} ");
    if(count==1) return 1;
    return num(count-1);
}
num(count);
Console.WriteLine();
