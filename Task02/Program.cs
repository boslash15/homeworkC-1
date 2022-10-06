// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Задай первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задай второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a - b > 0)
{
    max = a;
}
    else max = b;

Console.WriteLine($"большее число - {max}");
