﻿// Напишите программу, которая на вход принимает 3-х-значное число и на выходе показывает 2-ю цифру этого числа. 
Console.WriteLine ("Введите трехзначное число");
int a=Convert.ToInt32(Console.ReadLine());
int b=-1;
 if(a>99 && a<1000) 
{
   b=a/10;
   a=b%10;
   Console.WriteLine("Среднее, по позиции, число = " +a);
}
else
Console.WriteLine("Вы ввели число не того формата.");
 