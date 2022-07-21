// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine ("Введите пятизначное число: ");
string? polindrom = Console.ReadLine ();


if (polindrom.Length==5)
{
    if (polindrom[0]==polindrom[4] && polindrom[1]==polindrom[3])
    {
        Console.WriteLine($"Число {polindrom} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Число {polindrom} не является полиндромом");
    }
}
else
{
    Console.WriteLine ("Это число не подходит, оно не пятизначное");
}
