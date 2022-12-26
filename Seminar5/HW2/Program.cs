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
