// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Enter number N: ");
string enterNum = Console.ReadLine();
int N = Convert.ToInt32(enterNum);

int a = 1;
while (a <= N)
{
    if (a % 2 == 0)
    {
        Console.WriteLine($"{a}");
    }
    a++;
}

Console.WriteLine();

// решение Габиля
// int k = 2;
// while (k <= N)
// {
//   Console.WriteLine($"{k}");
//   k+=2;
// }