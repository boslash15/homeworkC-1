// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели, для определения выходного дня: ");
int dayweek = Convert.ToInt32(Console.ReadLine());

if (dayweek < 0) Console.WriteLine("некорректно введен день недели");
else if (dayweek > 7) Console.WriteLine("некорректно введен день недели");

bool dayOff = DayOff(dayweek);
if (dayOff) Console.WriteLine("да");
else Console.WriteLine("нет");


bool DayOff(int dweek)
{
    if (dweek == 6) return true;
    if (dweek == 7) return true;
    return false;
}
