// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string? i = Console.ReadLine();
    void check(string i){
        if (i[0] == i[4] && i[1] == i[3]){
            Console.WriteLine($"Число {i} - это палиндром");
            }
            else {
                Console.WriteLine($"Число {i} - это НЕ палиндром");
            }
    }
if (i!.Length == 5) {
check(i);
}
else {
    Console.WriteLine($"{i} - не пятизначное число");
}