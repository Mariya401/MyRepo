// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int index = 3;

if (num < 100)
{
   Console.WriteLine("Третьей цифры в числе нет");
   return;
}
       int ThirdNum = (num / 100) % 10;

    Console.WriteLine($"Третья цифра в числе: {ThirdNum}");


// Решение Габиля
// static void ViewaThirdNumber(int num, int index)
// {
//     if (num > 99)
//     {
//          int lenght = (int)Math.Log10(num);
//          int numberPow = (int)Math.Pow(10, lenght - index);
//          int result = num / numberPow % 10;
//          Console.WriteLine($"{index} цифра в числе {num} -> {result}");
//     }
//     else
//          Console.WriteLine($"У числа нет трех цифр");
// }
