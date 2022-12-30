// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter numbers: ");             // ввод чисел с клавиатуры
string str = Console.ReadLine();                // считывает и преобразует в массив
//Console.WriteLine(String.Join(", ", strArray));       // выводит на экран массив

var strArray = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);  // метод, который разделяет введеный текст на строки через разделитель " ",
// и удаляет пустые символы

int[] intArray = Array.ConvertAll(strArray, Convert.ToInt32); // конвертация строкового массива в массив с числами

int count = 0;


foreach (int el in intArray)
{
    if (el >= 0)
    {
        count++;
    }
}
Console.WriteLine(count);

/*
for (int i = 0; i < intArray.Length; i++)
{
    if (intArray[i] > 0)
    {
        count++;
    }
}
Console.WriteLine(count);
*/
