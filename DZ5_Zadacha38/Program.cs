// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Console.WriteLine("Введите какое количество символов будет в массиве");
int u=Convert.ToInt32(Console.ReadLine());
float[] array=new float[u];
for (int i=0; i<u; i++)
{
    array[i]=new Random().Next(-100,100);
    Console.Write(" "+ array[i]);
} 
Console.WriteLine(" ");
float max=-100;
float min=100;
for (int i=0; i<u; i++)
{
    if (max < array[i])
    max=array[i];
    if (min>array[i])
    min=array[i];
} 
Console.WriteLine("max="+max);
Console.WriteLine("min="+min);
Console.WriteLine( $"Разница между максимальным и минимальным числом = {max - min} ");