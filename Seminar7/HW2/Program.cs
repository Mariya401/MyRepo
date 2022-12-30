﻿// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Исправение Габиля = Юзер вводит значение элемента и программа возвращает индексы этого элекмента.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int el = int.Parse(Console.ReadLine());

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

/*void CheckArray(int[,] checkArray)
{
    for (int i = 0; i < checkArray.GetLength(0); i++)
    {
        for (int j = 0; j < checkArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                checkArray [i,j] = Convert.ToInt32(Math.Pow(checkArray[i, j], 2));
        }

    }
    */
/*int FindElement(int[,] el);

int index = array.findIndex(item);
        if (index != -1)
        {
            Console.WriteLine(String.Format("Element {0} is found at index {1}", item, index));
        }
        else 
            Console.WriteLine("Element not found in the given array.");

*/
int FindElement(int[,] el);

 if (FindElement(array, el, out int row, out int column))
            {
                Console.WriteLine($"Элемент найден: строка = {0} столбец ={1}");
            }
            else
            {
                Console.WriteLine("Элемент не найден");
            }