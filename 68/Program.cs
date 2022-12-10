// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int RecAccer(int n, int m)
{
    if (n == 0)
    {
        return m+1;
    }
    else if (m == 0)
    {
        return RecAccer (n-1, 1);
    }
    return RecAccer(n-1, RecAccer(n, m-1));
}
Console.Write("Введите значение m: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение n: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("A(m,n) = " + RecAccer(M,N));