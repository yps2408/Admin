// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int userNumber1 = new int();
int userNumber2 = new int ();
Console.WriteLine("Ведите первое число:");
userNumber1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
userNumber2 = Convert.ToInt32 (Console.ReadLine());
if (userNumber1> userNumber2)
{
    Console.WriteLine($"Большее число max ={userNumber1}. Меньшее число min= { userNumber2 }");
}
else
{
    Console.WriteLine($"Большее число max={userNumber2}.Меньшее число min={userNumber1}");

}
