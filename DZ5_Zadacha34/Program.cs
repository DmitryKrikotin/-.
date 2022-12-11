// Задача34 Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
Console.WriteLine("Введите какое количество символов будет в массиве");
int u=Convert.ToInt32(Console.ReadLine());
int[] array=new int[u];
int m=0;
for (int i=0; i<u;i++)
{
    array[i]=new Random().Next(100,1000);
    Console.Write(" "+ array[i]);
} 
Console.WriteLine(" ");   
for (int i=0; i<u; i++)
{
    if (array[i]%2==0)
    m++;
}    
Console.WriteLine("Количество четных чисел в массиве:"+m);