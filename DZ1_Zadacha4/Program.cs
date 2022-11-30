Console.WriteLine("Здравствуйте. Программа скажет какое из чисел большее. ");
Console.Write("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c=Convert.ToInt32(Console.ReadLine());
if ((a!=b)||(a!=c)||(b!=c))
{

  if ((a>b)&&(a>c))
  {
    Console.WriteLine("Максимальное значение =" +a);
  }
  if ((b>a)&&(b>c))
  {
    Console.WriteLine("Максимальное значение =" +b);
  }
  if ((c>a)&&(c>b))
  {
    Console.WriteLine("Максимальное значение =" +c);
  }
}
if (a==b)
    { 
        if (a>c)
        {
            Console.WriteLine("Максимальное значение =" +a);
        }
        else
        {
            Console.WriteLine("Максимальное значение =" +c);
        }
    }
    if (c==b)
    { 
        if (c>a)
        {
            Console.WriteLine("Максимальное значение =" +c);
        }
        else
        {
            Console.WriteLine("Максимальное значение =" +a);
        }
    }
    if (a==c)
    { 
        if (a>b)
        {
            Console.WriteLine("Максимальное значение =" +a);
        }
        else
        {
            Console.WriteLine("Максимальное значение =" +b);
        }
    }
    if ((a==b)&&(b==c))
    {
            Console.WriteLine("Максимальное значение =" +a);
        }

Console.WriteLine("Спасибо за использование данного ПО");
