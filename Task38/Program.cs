// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найти максимальный и минимальный элементы массива.
// 3. Найти разницу между максимальным и 
// минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, double min, double max)
{
    var array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(rndNum, 1);
    }
    return array;
}
 
void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MinElement(double[] array) 
{
    double minElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < minElement) minElement = array[i];
    }
    return  minElement;
}

double MaxElement(double[] array) 
{
    double maxElement = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxElement) maxElement = array[i];
    }
    return  maxElement;
}

double[] newArray = CreateArrayRndDouble(6, 1, 100);
PrintArrayDouble(newArray);
double min =  MinElement(newArray);
double max =  MaxElement(newArray);
double dif = Math.Round(max - min, 1);
Console.WriteLine($"Разница между максимальным [{max}] и минимальным [{min}] элементами массива равна {dif}");
