// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write ("Напишите номер четверти: ");
int n = Convert.ToInt32 (Console.ReadLine());
if (n<1 || n>4)
{
    Console.WriteLine ("Таких четвертей нет");
}
else 
{
    if (n ==1)
{
    Console.Write ("Диапазон (x>0, y>0)");
}
    if (n ==2)
{
    Console.Write ("Диапазон (x<0, y>0)");
}
if (n ==3)
{
    Console.Write ("Диапазон (x<0, y<0)");
}
if (n ==4)
{
    Console.Write ("Диапазон (x>0, y<0)");
}
}