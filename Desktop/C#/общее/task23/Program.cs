﻿// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= userNumber; i++)
{
    int result = i * i * i;
    if (i == userNumber)
    {
        Console.WriteLine(result);
    }
    else
    {
    Console.WriteLine(result + ",");
    }
}