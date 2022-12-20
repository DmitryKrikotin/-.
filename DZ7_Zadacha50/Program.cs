// Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
Console.WriteLine("Проверка наличия в массиве числа ");
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
Console.WriteLine("Введите искомое число");
int find=Convert.ToInt32(Console.ReadLine());
bool o=false;
for (int i=0; i<m; i++)
{
    for (int j=0;j<n; j++)
    {
        if (find==array[i,j]) o=true;
    }
    
}
if (o==true) Console.WriteLine("Число присутствует в массиве");
else Console.WriteLine("Число не присутствует в массиве");
Console.WriteLine("Введите искомые координаты числа");
Console.Write("строка:");
int find1=Convert.ToInt32(Console.ReadLine());
Console.Write("столбец:");
int find2=Convert.ToInt32(Console.ReadLine());
if (find1<=m)
if (find2<=n) Console.WriteLine($"Искомое число= {array[find1,find2]} ");
else Console.WriteLine("Число не присутствует в массиве");