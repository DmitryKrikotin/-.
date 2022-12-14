// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Эта программа считает точку пересечения двух прямых");
Console.WriteLine("Формулы для вычисления прямых y=k1*x+b1,y=k2*x+b2");
Console.WriteLine("Введите коэффициент k1");
int k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
int b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
int k2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
int b2=Convert.ToInt32(Console.ReadLine());
double y;
double x;
double a;
double b;
if(k1!=k2)
{
    a=((b1*k2)-(b2*k1));
    b=(k2-k1);
    y=a/b;
    x=(y-b2)/k2;
    Console.WriteLine($"координаты точки пересечения:({x};{y})");
    }
else Console.WriteLine($"Прямые не пересекаются");