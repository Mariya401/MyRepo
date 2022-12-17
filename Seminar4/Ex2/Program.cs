// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int temp = num;
// int revert = 0;
// int i = 0;

// while (temp > 0)

// {
//     revert = (revert * 10) + (temp % 10);
//     temp /= 10;
//     i++;
// }
// Console.WriteLine($"Число {i} - значное ");


Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());
int i = 0;

for (; num > 0; i++)
{
    num /= 10;
}
Console.WriteLine($"Число {i} - значное ");