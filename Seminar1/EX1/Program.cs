// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее//
Console.WriteLine ("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
//сравниваем два числа//
if   (a>b) Console.WriteLine ("Число а больше числа b");
else
Console.WriteLine ("Число b больше числа а");