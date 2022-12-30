// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 
// [-4, -6, 89, 6] -> 0

int[] array = new int[7];
var random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 10);
}
Console.WriteLine(String.Join(" ", array));

int sum = 0;
foreach (int num in array)
{
    if (num % 2 != 0)
    {
        sum += num;
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");

/*
// Решение Габиля
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

 startArray = GetArray(6, 0, 999);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Сумма элементов на нечетных позициях = {GetSumOdd(startArray)}");


int GetSumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}
*/