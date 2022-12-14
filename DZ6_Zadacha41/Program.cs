// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите количество цифр массива:");
int M=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа массива");
int[] arr=new int[M];
for (int i=0;i<M;i++)
{
    Console.WriteLine($"{i+1} элемент");
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int k=0;
for (int i=0;i<M;i++)
{
    if(arr[i]>0) k++;
}
Console.WriteLine($"Количество чисел >0 = {k}");
