﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.(необязательная)
m = 2, n = 3 -> A(m,n) = 9*/

Console.Clear();
int = = InputNumbers("Введите m: ");
int = = InputNumbers("Введите n: ");

int = = Ack(m, n);

Console.Write($"Функция Akk={functionAkkerman}");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}