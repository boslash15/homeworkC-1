// Задача 43: 
// Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double[] IntersectionPoint(int b1, int b2, int k1, int k2)
{
    double[] point = new double[2];
    point[0] = Math.Round((b1 - b2) / (k2 - k1), 1);
    point[1] = Math.Round(k1 * point[0] + b1, 1);
    return point;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine($"Точка пересечения двух прямых, заданных уравнениями y = {k1} * x + {b1}, y = {k2} * x + {b2}:");
double[] intersectionPoint = IntersectionPoint(b1, b2, k1, k2);
PrintArray(intersectionPoint);

