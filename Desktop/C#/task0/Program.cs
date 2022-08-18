internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число 1:");
        int userNumber1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Возможный квадрат:");
        int userNumber2 = Convert.ToInt32(Console.ReadLine());

        if ( userNumber2 == userNumber1 * userNumber1)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}

