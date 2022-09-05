// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
int [] GetArray(int size,int minValue,int maxValue)
{
    int []res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res [i]= new Random().Next(minValue,maxValue +1);
        Console.WriteLine($"{res[i]}");
    }
    return res;
}
int [] array = GetArray(6,-99,99);
Console.WriteLine();

int sumOddIndex = 0;
for (int i =1; i <array.Length; i=i+2)
{
    sumOddIndex = sumOddIndex + array[i];
}
Console.WriteLine($"Сумма элементов массива,стоящих на нечетных позициях равна {sumOddIndex}");
