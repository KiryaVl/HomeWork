// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// d=√(x2-x1)²+(y2-y1)²+(z2-z1)²

Console.WriteLine("Введите координату X точки А: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X точки B: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B: ");
int Bz = Convert.ToInt32(Console.ReadLine());


double d = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay,2) + Math.Pow(Bz - Az,2)), 2);
Console.WriteLine($"Расстояние между точками А и В : {d} ед.");