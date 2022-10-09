﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Решение без метода
// int result = 0;
// result = number / 10 % 10;
// Console.WriteLine($"Вторая цифра введенного числа - {result}");

// решение с методом
int secondDigit = SecondDigit(number);
Console.WriteLine($"Вторая цифра введенного числа - {secondDigit}");

int SecondDigit(int num)
{
    return num / 10 % 10;
}

