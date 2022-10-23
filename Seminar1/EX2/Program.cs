// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел//
Console.WriteLine ("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a>b & a>c)
Console.WriteLine ("a = максимальное число");
if (b>a & b>c)
Console.WriteLine ("b = максимальное число");
if (c>b & c>a) 
Console.WriteLine ("c = максимальное число");
