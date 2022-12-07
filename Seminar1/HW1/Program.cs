// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Enter number 1: ");
string enterNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(enterNum1);   // можно использовать int.Parse(Console.ReadLine())
Console.WriteLine("Enter number 2: ");
string enterNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(enterNum2);

if (num1 > num2)
{
    Console.WriteLine("Number 1 > Number 2");
}
else if (num1 < num2)
{
    Console.WriteLine("Number 1 < Number 2");
}
else
{
    Console.WriteLine("Number 1 = Number 2");
}