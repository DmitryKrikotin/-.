// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
Console.WriteLine("Введите число, которое нужно возвести в степень");
int A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число, степень, в которую нужно возвести число");
int B=Convert.ToInt32(Console.ReadLine());
int stepen=1;
for (int i=0; i<B; i++)
 {
   stepen=stepen*A;
 }
 Console.WriteLine("результат= "+stepen);
