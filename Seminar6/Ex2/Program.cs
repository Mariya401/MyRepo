// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

//if (a+b>c && a+c>b && b+c>a)
//{
//    Console.WriteLine("Треугольник существует");
//}
//else
//{
//Console.WriteLine("Треугольник НЕ существует");
//}


// решение с bool (но без true / false)
bool isTriangle(int a, int b, int c)        // с bool имена пишутся через is (так принято)
{
return a+b>c && a+c>b && b+c>a;
}                         
if (isTriangle(a, b, c))                    // помещаем сюда метод (можно еще через Console.WriteLine)
{
    Console.WriteLine("Треугольник существует");
}
else
{
Console.WriteLine("Треугольник НЕ существует");
}