﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Enter X: ");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Y: ");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("1");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("2");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("3");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("4");
}
