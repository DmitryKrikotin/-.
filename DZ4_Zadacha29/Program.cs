// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите какое количество символов будет в массиве");
int u=Convert.ToInt32(Console.ReadLine());
int[] array=new int[u];
for (int i=0; i<u;i++)
{
    array[i]=new Random().Next(0,101);
    Console.Write(" "+ array[i]);
}