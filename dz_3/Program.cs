// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber( int m,int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return SumNumber(m - 1, 1);
    }
    else
    {
        return (SumNumber(m - 1, SumNumber(m, n - 1)));
}
}
Console.Write(SumNumber(m, n)); 