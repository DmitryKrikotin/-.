// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine("Программа выводит сумму чисел от N до M");
Console.Write("Введите число N ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M ");
int m=Convert.ToInt32(Console.ReadLine());
if (n>m) (n,m)=(m,n);
void num (int n, int m, int sum)
{
    if (n>m) 
    { 
     Console.WriteLine($"{sum} ");
     return;
    }
     sum+=(n++);
    num(n,m,sum);
}
num(n,m,0);
Console.WriteLine();
