// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter B: ");
int B = int.Parse(Console.ReadLine());

int C = 1;

for (int i=1; i<=B; i++)
{
C = C*A;
}
Console.WriteLine(C);