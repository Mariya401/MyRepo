// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Enter number 1: ");
string enterNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(enterNum1);   // можно использовать int.Parse(Console.ReadLine())
Console.WriteLine("Enter number 2: ");
string enterNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(enterNum2);
Console.WriteLine("Enter number 3: ");
string enterNum3 = Console.ReadLine();
int num3 = Convert.ToInt32(enterNum3);

int max = num1;

if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
Console.WriteLine($"Max = {max}");
