﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int userNumber1 = new int ();
Console.WriteLine("Ведите первое число");
userNumber1 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= userNumber1; i++)
{
    if (i%2 ==0)
    {
        Console.WriteLine($"{i}");
    }
}

