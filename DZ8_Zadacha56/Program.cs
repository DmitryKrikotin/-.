// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
  
Console.WriteLine("Задайте прямоугольный массив, получите номер строки с наименьшей суммой ");
Console.WriteLine("Введите колличество строк массива");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов массива");
int n=Convert.ToInt32(Console.ReadLine());
if (m==n) Console.WriteLine("Массив не прямоугольный");
int[,] array= new int[m,n];
Random random = new Random();
for (int i=0; i<m; i++)
{
    for (int j=0;j<n; j++)
    {
     array[i,j]=random.Next(1,10);
     Console.Write($"{array[i, j],3} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
int maxSum=0;
int sum=0;
int indexMax=0;
int secondIndexMax=0;
int secondMaxSum=0;
for(int i=0;i<m;i++)
{
  for(int j=0;j<n;j++)
  
  { {sum+=array[i,j];
    Console.WriteLine(sum);}
   if(maxSum<sum)
    {
      indexMax=i;
      maxSum=sum;
    }
  }
   if (maxSum==sum)
    {
      secondIndexMax=i;
      secondMaxSum=sum;;
    }
  
 Console.WriteLine();
 sum=0;
}
Console.WriteLine($"Строка с максимальной суммой-{indexMax+1}  ");
if ((secondMaxSum==maxSum)&&(indexMax!=secondIndexMax)) Console.WriteLine($"Строка вторая с той же суммой-{secondIndexMax+1}");