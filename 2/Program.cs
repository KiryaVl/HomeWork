//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (number < number2)
{
    max = number2;
    min = number;
    Console.WriteLine($"{max} является большим числом,чем {min}");
}
else if (number > number2)
{
    max = number;
    min = number2;
    Console.WriteLine($"{max} является большим числом,чем {min}");
}
else 
{
 Console.WriteLine("Они одинаковые Наташ!");
}