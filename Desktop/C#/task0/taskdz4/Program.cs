// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int userNumber1 = new int ();
int userNumber2 = new int ();
int userNumber3 = new int ();
Console.WriteLine ("Введите первое число");
userNumber1= Convert.ToInt16(Console.ReadLine());
Console.WriteLine ("Введите второе число");
userNumber2 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Ведите третье число");
userNumber3 = Convert.ToInt32(Console.ReadLine());
 int result = userNumber1 > userNumber2 && userNumber1> userNumber3
 ? userNumber1 : userNumber2 > userNumber1 && userNumber2 > userNumber3
 ? userNumber2 : userNumber3;
 Console.WriteLine(result);



