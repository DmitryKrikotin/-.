// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
string a=Console.ReadLine();
int i=a.Length;
int c=Convert.ToInt32(a);
int[] array={0,0,0,0,0};
int o=0;
int b=-1;
int j;
if (i!=5) Console.WriteLine("Ввели число не пятизначное");
else 
{
    i=4;
    while (i!=-1)
    {
        o=c%10;
        array[i]=o;
        c=c/10;
        i=i-1;
    }
    i=0;
    j=4;
    while(i<2&&j>2)
    {     
        if (array[i]==array[j]) 
        {             
         b++;
        }
        i++;
        j=j-1;
        
    }
    if (b==1) Console.WriteLine("Число является полиндромом");
    if (b!=1) Console.WriteLine("Число не является полиндромом");
}