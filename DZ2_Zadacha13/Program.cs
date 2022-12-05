//Напишите программу, которая принимает на вход цифру обозначающий день недели и проверяет является ли этот день выходным.
Console.WriteLine("Введите цифру, обозначающую день недели");
int day=Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
     Console.WriteLine("Понедельник-будний день");
     break;
     case 2:
     Console.WriteLine("Вторник- будний день");
     break;
     case 3:
     Console.WriteLine("Среда- будний день");
     break;
     case 4:
     Console.WriteLine("Четверг- будний день");
     break;
     case 5:
     Console.WriteLine("Пятница- будний день");
     break;
     case 6:
     Console.WriteLine("Суббота-выходной");
     break;
     case 7:
     Console.WriteLine("воскресенье - выходной");
     break;
    default:
     Console.WriteLine("В неделе 7 дней");
     break;
}