// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] > [5 4 3 2 1] [6 7 3 6] > [6 3 7 6]

/* int[] startArray = GetArray(5, 1, 10);  // (5 - кол-во эл-тов в массиве, 1 - начало масиива, 10 - конец массива)
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"- {startArray}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
// есть 2 варианта решения: 1 - создаем новый массив, зписывая по очереди числа первого массива с конца, 
//2 - переписываем старый, меняя местами первый и последний эл-т массива.

int[] reverse(int[] array)
{
    for (int i = 0; i < length; i++)
    
}
*/

int[] array1 = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array1));

ReversArray1(array1);
Console.WriteLine(String.Join(" ", array1));

array1 = ReversArray2(array1);
Console.WriteLine(String.Join(" ", array1));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReversArray1(int[] inArray)       //9 8 34 5 67 2 1    // проходим наш массив, пока он не будет равен 4, т.к. делим на 2.
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int tmp = inArray[i];                             // создаем перем. тмп, сначала равен 1 (первый эл-т массива)
        inArray[i] = inArray[inArray.Length - i - 1];     // затем переписываем на 9 (посл.эл-т массива)
        inArray[inArray.Length - i - 1] = tmp;            // последний эл-т массива переписываем на 1 (первый эл-т массива)
    }                                                     // так по кругу
}

int[] ReversArray2(int[] inArray)                         // создали новый массив и с конца записываем начало первого массива
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];

    }
    return result;
}