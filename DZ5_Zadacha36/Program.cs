//Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
Console.WriteLine("Введите какое количество символов будет в массиве");
int u=Convert.ToInt32(Console.ReadLine());
int[] array=new int[u];
int m=0;
for (int i=0; i<u;i++)
{
    array[i]=new Random().Next(0,100);
    Console.Write(" "+ array[i]);
} 
Console.WriteLine(" ");
for (int i=0; i<u; i++)
{
    if (i%2!=0)
    m=m+array[i];
} 
Console.WriteLine("Сумма элементов на нечетных позициях =" +m);