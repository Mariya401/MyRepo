// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Enter number 1: ");
string enterNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(enterNum1);
Console.WriteLine("Enter number 2: ");
string enterNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(enterNum2);

if (num1 == num2 * num2)
    Console.WriteLine("Первое число являтся квадаратом второго");
else
    Console.WriteLine("Первое число НЕ являтся квадаратом второго");
