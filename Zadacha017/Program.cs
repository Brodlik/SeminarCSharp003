// Программа принимает на вход координаты точки x и y, причем x ≠ 0 и y ≠ 0. Выдает номер четверти
// плоскости, в которой находится эта точка.
// Решение задачи через массив

int[] point = new int[2];

Console.WriteLine("Введите координату точки X: ");
point[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки Y: ");
point[1] = Convert.ToInt32(Console.ReadLine());

if (point[0] == 0 || point[1] ==0)
{
    Console.WriteLine("Точка лежит на плоскости");
}

if (point[0] > 0 && point[1] > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
if (point[0] < 0 && point[1] > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
if (point[0] < 0 && point[1] < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
if (point[0] > 0 && point[1] < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}
