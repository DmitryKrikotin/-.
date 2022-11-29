Console.WriteLine("Здравствуйте. Программа скажет какое из двух чисел наибольшее, а какое наименьшее. ");
Console.Write("Введите первое число: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a!=b)
{

  if (a>b)
  {
    Console.WriteLine("Максимальное значение =" +a);
    Console.WriteLine("Минимальное значение =" +b);
  }
  else
  {
    Console.WriteLine("Максимальное значение =" +b);
    Console.WriteLine("Минимальное значение =" +a);
  }
}
else
{
    Console.WriteLine("Значения равны");
}
Console.WriteLine("Спасибо за использование данного ПО");