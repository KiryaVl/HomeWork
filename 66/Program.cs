// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Rec(int n, int m)
{
    if (m == n)
    {
        return m;
    }
    return m + Rec(n, m-1);
}
Console.Write("Введите первое значение: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Введите второй значение: ");
int M = int.Parse(Console.ReadLine());
if (N>M)
{
    int temp = 0;
    temp = N;
    N = M;
    M = temp;
}
Console.WriteLine(Rec(N,M));
