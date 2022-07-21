// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write ("Введите X1: ");
int X1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите X2: ");
int X2 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите Y1: ");
int Y1 = Convert.ToInt32 (Console.ReadLine());

Console.Write ("Введите Y2: ");
int Y2 = Convert.ToInt32 (Console.ReadLine());

double result = Math.Sqrt (Math.Pow (X2-X1, 2) + Math.Pow (Y2-Y1, 2));
Console.WriteLine (result);




// int[] array1 = new int [] {x1, y1};
// int[] array2 = new int [] {x2, y2};

// double distance = Math.Sqrt(Math.Pow(array2[0] - array1[0], 2) + Math.Pow(array2[1] - array1[1], 2));

// Console.WriteLine(distance);
