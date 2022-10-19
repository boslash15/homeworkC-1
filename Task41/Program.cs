// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Ввод количества чисел.
// Ввод самих чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите сколько чисел надо проверить: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] InputArray(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int PositiveNumber(int[] array)
{
    int positive = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positive++;
    }
    return positive;
}

int[] arr = InputArray(number);
PrintArray(arr);
int positiveNumber = PositiveNumber(arr);
Console.WriteLine($"Количество положительных чисел в заданном нами массиве = {positiveNumber}");