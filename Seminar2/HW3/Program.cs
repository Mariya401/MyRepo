// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter day number: ");
string dayNum = Console.ReadLine();
int day = Convert.ToInt32(dayNum);

if (day == 1)
    Console.WriteLine("Monday - no");
else if (day == 2)
    Console.WriteLine("Tuesday - no");
else if (day == 3)
    Console.WriteLine("Wednesday - no");
else if (day == 4)
    Console.WriteLine("Thursday - no");
else if (day == 5)
    Console.WriteLine("Friday - no");
else if (day == 6)
    Console.WriteLine("Saturday - yes");
else if (day == 7)
    Console.WriteLine("Sunday - yes");
else
    Console.WriteLine("Некорректный номер дня недели");
