// Задача 68: Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите первое неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());


int FunkAkkerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    if (num2 == 0) return FunkAkkerman(num1 - 1, 1);
    return FunkAkkerman(num1 - 1, FunkAkkerman(num1, num2 - 1));
}

int funkAkk = FunkAkkerman(n, m);
Console.WriteLine($"{funkAkk}");
