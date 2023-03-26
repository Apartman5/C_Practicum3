// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве
// Примеры:
// A(3, 6); B(2, 1) -> 5,09
// A(7, -5); B(1, -1) -> 7,21

double[] pointA = new double [2];
double[] pointB = new double [2];
double distance = 0;

Console.WriteLine("введите координаты первой точки - X и Y");
for (int i = 0; i < pointA.Length; i ++)
    pointA[i] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты второй точки - X и Y");
for (int i = 0; i < pointB.Length; i ++)
    pointB[i] = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2));
Console.WriteLine($"Растояние между точками равно {Math.Round(distance, 3)}");