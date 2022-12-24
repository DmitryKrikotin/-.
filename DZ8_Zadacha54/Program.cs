// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Упорядычевание элементов массива по убыванию в строке ");
Console.WriteLine("Введите колличество строк массива");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов массива");
int n=Convert.ToInt32(Console.ReadLine());
int[,] array= new int[m,n];
Random random = new Random();
for (int i=0; i<m; i++)
{
    for (int j=0;j<n; j++)
    {
     array[i,j]=random.Next(1,20);
     Console.Write($"{array[i, j],3} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for(int i=0;i<m;i++)
{
  for(int j=0;j<n;j++)
  {
   for(int k=0;k<n-1;k++)
   {
    if(array[i,k]<array[i,k+1])
    {
      int temp=array[i,k+1];
      array[i,k+1]=array[i,k];
      array[i,k]=temp;
    }
   }
//  Console.Write($"{array[i, j],4}  ");
  }
// Console.WriteLine();
}
for(int i=0;i<m;i++)
{
  for(int j=0;j<n;j++)
  {
    Console.Write($"{array[i, j],3}  ");
  }
  Console.WriteLine();
}
