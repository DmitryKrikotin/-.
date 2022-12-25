// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.WriteLine("Программа перемножение матриц");
int m=3;
int n=3;
int[,] array1= new int[m,n]; //первая матрица для перемножения
int[,] array2= new int[m,n]; //вторая матрица для перемножения
int[,] resultArray= new int[m,n]; //результирующая матрица
Random random = new Random();
for (int i=0; i<m; i++)
{
    for (int j=0;j<n; j++)
    {
     array1[i,j]=random.Next(1,10);
     Console.Write($"{array1[i, j],3}");
    }
    Console.Write('|');
    for (int k=0;k<n;k++)
    {
         array2[i,k]=random.Next(1,4);
         Console.Write($"{array2[i, k],3}");
    }
    Console.WriteLine();
}
for (int i=0; i<m; i++)  
{
    for (int j=0;j<n; j++)
    {  
     for (int index1=0;index1<n;index1++)
      resultArray[i,j]+=(array1[i,index1]*array2[index1,j]);
    }
}
Console.WriteLine($"Матрица после перемножения:");
for (int i=0; i<m; i++)
{
    for (int j=0;j<n;j++)
        Console.Write($"{resultArray[i,j],3}");
    Console.WriteLine();    
}
Console.WriteLine();
