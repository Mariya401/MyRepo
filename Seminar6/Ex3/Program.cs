// Задача 45:
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] array = GetArray(5, 1, 21);                    //без нижнего описания метод работать не будет
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Копия массива - {String.Join(" ", Copy(array))}");  // поместили метод, чтобы он отобразился

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
int[] Copy(int[] array)    
{
    int [] newArray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];                              
    }      
    return newArray;                                               
}