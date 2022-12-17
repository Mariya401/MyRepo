// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine());
int a = 1;

for (int i=1; i<=N; i++)
{
a = a*i;
}
Console.WriteLine(a);
