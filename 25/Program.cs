// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int A = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Введите степень: ");
int B = Math.Abs(Convert.ToInt32(Console.ReadLine()));
double pow = 1;
for(double i=0; i<B; i++) {
   pow*=A;
  }
Console.WriteLine($"{A} ^ {B} = {pow}");
