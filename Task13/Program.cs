// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5 - здесь наверное нужно выводить 6?
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit(number);

if (secondDigit == 0) Console.WriteLine("третьей цифры нет");
else Console.WriteLine($"Третья цифра введенного числа - {secondDigit}");

int SecondDigit(int num)
{
    if (num > 99) return num / 100 % 10;
    return 0;
}