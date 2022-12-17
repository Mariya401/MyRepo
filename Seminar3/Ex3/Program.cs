// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Enter x1: ");
int xa = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y1: ");
int ya = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x2: ");
int xb = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y2: ");
int yb = int.Parse(Console.ReadLine());

double AC = (xb - xa);
double BC = (yb - ya);

double AB = Math.Pow(AC, 2) + Math.Pow(BC, 2);

double result = Math.Sqrt(AB);

Console.WriteLine(result);
