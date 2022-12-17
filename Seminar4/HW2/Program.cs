﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine());
int sum = 0;

while (N > 0)
{
    sum += N % 10;
    N /= 10;
}
Console.WriteLine(sum);