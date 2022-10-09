// Задача 19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int turnOver = TurnOver(number);
if (number == turnOver) Console.WriteLine($"Число {number} является палиндромом");
else Console.WriteLine($"Число {number} не является палиндромом");


int TurnOver(int num)
{
    int num1 = num % 10 * 10000 + num / 10 % 10 * 1000 + num / 100 % 10 * 100 + num / 1000 % 10 * 10 + num / 10000;
    return num1;
}
