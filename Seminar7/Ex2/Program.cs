// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

var array = GetArrayMatrix(rows, columns, 0, 10);
PrintArray(array);
CheckArray(array);
Console.WriteLine();
PrintArray(array);

int[,] GetArrayMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void CheckArray(int[,] checkArray)
{
    for (int i = 0; i < checkArray.GetLength(0); i++)
    {
        for (int j = 0; j < checkArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                checkArray [i,j] = Convert.ToInt32(Math.Pow(checkArray[i, j], 2));
        }

    }

}