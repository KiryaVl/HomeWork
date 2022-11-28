// Задача 38: Задайте массив вещественных(тип double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



double [] FillArray(int size)
{
    double [] arr = new double [size];
    for(int i = 0; i < arr.Length; i++)
    {
        Random x = new Random();                                                                                //пришлось покапаться в гуглах чтоб этот метод заработал
        double r = Convert.ToDouble(x.Next(100)/10.0);                                          
        arr[i] = r;
    }
    return arr;
}
Console.Write("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
double [] array = FillArray(num);
Console.WriteLine("Массив: " + string.Join("; ", array));
Console.WriteLine("Наименьший элемент " + array.Min());
Console.WriteLine("Наибольший элемент " + array.Max());
var max = array[0];
var min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    { 
        min = array[i];
    }    
    if (array[i] > max) 
    {
        max = array[i];
    }
}       
Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);
