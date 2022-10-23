// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N//
Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
 int res = 1;
       
    if (res == 1)

        {
         res += 1;
        }

    while (res <= number)

        {
            Console.WriteLine(res);
            res += 2;
        }