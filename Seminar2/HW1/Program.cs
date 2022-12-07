// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Enter number: ");
int num = int.Parse(Console.ReadLine());

if ((num > 99) && (num < 1000))
{
    int SecondNum = (num / 10) % 10;
    
    Console.WriteLine($"Вторая цифра в числе: {SecondNum}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}