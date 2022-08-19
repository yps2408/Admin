// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int userNumber1 = new int ();
Console.WriteLine("Введите первое число:");
userNumber1 = Convert.ToInt32(Console.ReadLine());
string result = userNumber1 % 2 == 0 ? "Да" : "Нет";
Console.WriteLine(result);
