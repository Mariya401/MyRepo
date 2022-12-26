// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] array = new int[10];
var random = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 10);
}
Console.WriteLine(String.Join(" ", array));

int min = 0;
int max = 0;
foreach (int i in array)
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Разница: {max-min}");