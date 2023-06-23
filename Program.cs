// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
	

Console.Write("Enter N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
SumFromMToN(m, n);
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Write("Enter N: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter M: ");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m,n);
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}