// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
int num = userNumber;
int i = 1;
    while (num > 9)
    {
        num = num/10;
        i++;
    }
Console.WriteLine($"В числе {userNumber} {i} цифр.");
