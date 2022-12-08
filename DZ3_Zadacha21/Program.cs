// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты двух точек");
Console.WriteLine("x1:");
double x1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1:");
double y1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1:");
double z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2:");
double x2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2:");
double y2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z2:");
double z2=Convert.ToInt32(Console.ReadLine());
double result=Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)+Math.Pow((z1-z2),2));
Console.WriteLine($"Расстояние между двумя точками = {result}");