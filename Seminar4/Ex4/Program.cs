// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arr = new int[8];

// for (int i = 0; i < 8; i++)
// {
//     var rnd = new Random();
//     arr[i] = rnd.Next(0,2);
//     Console.Write(arr[i] + ", ");
// }

// Еще одно решение:
int[] array = new int[8];
var random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 2);
}
Console.Write(string.Join(", ", array));