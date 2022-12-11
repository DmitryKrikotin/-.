// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе;
Console.WriteLine("Введите число:");
string A=Console.ReadLine();
int i=A.Length;
int B=Convert.ToInt32(A);
int result=0;
int l=0;
for (int u=0;u<i;u++)
{
    l=B%10;
    B=B/10;
    result=result+l;
    Console.WriteLine(result);
}
Console.WriteLine("Сумма равна=" + result);