// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter x1: ");
int xa = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y1: ");
int ya = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z1: ");
int za = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x2: ");
int xb = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y2: ");
int yb = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z2: ");
int zb = int.Parse(Console.ReadLine());

double AB1 = (xb - xa);
double AB2 = (yb - ya);
double AB3 = (zb - za);

double AB = Math.Pow(AB1, 2) + Math.Pow(AB2, 2) + Math.Pow(AB3, 2);

double result = Math.Sqrt(AB);

Console.WriteLine(result);



// Решение Габиля:

// int SetNumber(string numberName)
// {
//     Console.Write($"Enter number {numberName}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// double DistanceBetween3DPoints(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }