// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 - среда
// 5 - пятница

Console.WriteLine("Enter day number: ");
string dayNum = Console.ReadLine();
int day = Convert.ToInt32(dayNum);
string WeekDay = "Monday";           //разобраться как это работает

if (day == 1) WeekDay = "Monday";
if (day == 2) WeekDay = "Tuesday";
if (day == 3) WeekDay = "Wednesday";
if (day == 4) WeekDay = "Thursday";
if (day == 5) WeekDay = "Friday";
if (day == 6) WeekDay = "Saturday";
if (day == 7) WeekDay = "Sunday";

// разобраться где ошибка (код не работает)

// if ((day > 7) || (day < 1))
// {
//    Concole.WriteLine("Enter a valid day number");
//    return;
// }
// Console.WriteLine(WeekDay);