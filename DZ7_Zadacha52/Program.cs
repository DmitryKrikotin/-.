// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Находим среднее арифмет в каждом столбце");
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
     array[i,j]=random.Next(1,100);
     Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
double k=0;
double a=0;
Console.Write("Среднее арифм элементов в каждом столбце = ");

 for (int j=0;j<n; j++)
 {
        for (int i=0; i<m; i++)
    {a=array[i,j];
     k+=Math.Round(a/m,2);
    }
    Console.Write($"{k} ");
    k=0;
}
Console.WriteLine();