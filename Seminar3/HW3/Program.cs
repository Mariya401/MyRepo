//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
double sqr = 1;
while (i <= N)
{
    sqr = Math.Pow(i, 3);       
        Console.Write($"{sqr}, ");
    i++;
}


// Решение Габиля:            Посмотреть не гитхабе!!!

// int[] CubeTable(int n)
// {
//     int[] arr = new int[n];

//     for (int i = 1; i <= n; i++)
//     {
//         arr[i - 1] = i * i * i;
//     }
//     return arr;
// }
// 
// Console.WriteLine(String.Join(",", arr));