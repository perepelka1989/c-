// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int n=Convert.ToInt32(Console.ReadLine());
string PrintNumber(int start, int end)
{
    if (end==start)
    {
        return end.ToString();
    }
    return(start +", " +PrintNumber(start-1, end));
}
Console.WriteLine(PrintNumber(n,1));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число m");
int m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n");
int n=Convert.ToInt32(Console.ReadLine());

int SumNumber(int m,int n)
{
    if (n<m)
    {
        return 0;
    }
        if (m==n)
    {
        return m;
    }
    return(m+SumNumber(m+1, n));
}
Console.WriteLine(SumNumber(m,n));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m");
int m=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n");
int n=Convert.ToInt32(Console.ReadLine());

int A(int m,int n)
{
    if (m==0)
    {
        return n+1;
    }
        if (n==0)
    {
        return (A(m-1,1));
    }
    return(A(m-1,A(m,n-1)));
}
Console.WriteLine(A(m,n));