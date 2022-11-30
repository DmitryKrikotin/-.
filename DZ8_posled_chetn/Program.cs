Console.WriteLine("Здравствуйте. Программа покажет все четные числа он 1 до N");
Console.Write("Введите положительное число: ");
int N=Convert.ToInt32(Console.ReadLine());
int i=1;
if (N>0)
{
    while (i<N+1)
    if (i%2==0)
    {
    Console.WriteLine(i);
    i++;
    }
    else
    {  
    i++;
    }
}
else
{
    Console.WriteLine("Число отрицательное.");
}