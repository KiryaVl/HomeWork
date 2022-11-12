// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (num1 > num2) 
{
    max = num1;
}
else
{
    max = num2;
}
if (num2 > num3)
{
   max = num2;
}
else
{
    max = num3;
}
if (num3 > num1)
{
    max = num3;
}
else
{
    max = num1;
}
Console.WriteLine($"{max} является самым большим числом");