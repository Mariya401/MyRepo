// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if ((num > 9999) && (num < 100000))
{
    int FirstNum = (num / 10000) % 10;
    int SecondNum = (num / 1000) % 10;
    int ThirdNum = (num / 100) % 10;                   // (/100-"отсекаем" две посл.цифры, %-модуль однозначного числа)
    int FourthNum = (num / 10) % 10;
    int FifthNum = (num / 1) % 10;

    if (FirstNum == FifthNum && SecondNum == FourthNum)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число НЕ является палиндромом");
    }
}
else
{
   Console.WriteLine("Число НЕ является пятизначным"); 
}



// Решение Габиля:                  !!!Разобраться!!!

// bool isPalindromeInt(int num)
// {
//     int temp = num;
//     int revert = 0;

//     while (temp > 0)
//     {
//         revert = (revert * 10) + (temp % 10);
//         temp /= 10;      // temp = temp / 10
//     }
//     return revert == num;
// }
// int numPalindrome = SetNumber("Palindrome");

// bool isPalindrome = IsPalindromeInt(numPalindrome);

// string str = isPalindrome ? "Является палиндромом" : "НЕ является палиндромом";    // if ; else

// Console.WriteLine($"число {numPalindrome} {str}");



