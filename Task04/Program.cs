// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Задай первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задай второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задай третье число: ");
int d = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b && a > d) max = a;
else 
    if (b > d) max = b;
    else max = d;

Console.WriteLine($"большее число - {max}");