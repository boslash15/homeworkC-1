// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double numberB = Convert.ToInt32(Console.ReadLine());

double degreeAinB = DegreeNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {degreeAinB}");

double DegreeNumber(double numA, double numB)
{
    double AinB = 1;
    if (numB > 0)
        {    
        while (numB > 0)
            {
            numB = numB - 1;
            AinB = AinB * numA;
            }
        }    
    else 
        if (numB < 0)
            {
            while (numB < 0)
                {
                numB = numB + 1;
                AinB = AinB / numA;
                }
            }
        else
            AinB = 1;   
    return AinB;
}