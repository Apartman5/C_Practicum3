// Задача 17
// Напишите программу, которая принимает на вход координаты точки (x, y)
// причем x != 0, y != 0 и выдает номер четверти плоскости, 
// в которой находится эта точка

int[] points = new int[2]; // создаем массив, обозначая его с помощью [], длина этого массива равна 2 (координаты на плоскости)

Console.WriteLine("Input X & Y");
for (int i = 0; i < points.Length; i ++)// вместо цикла while можно использовать цикл for
    points[i] = Convert.ToInt32(Console.ReadLine());
if(points[0] > 0 && points[1] > 0) //points[0] - X, points[1] - Y
    Console.WriteLine("It`s first quadrant");
    else if(points[0] < 0 && points[1] > 0) 
        Console.WriteLine("It`s second quadrant");
        else if(points[0] < 0 && points[1] < 0) 
            Console.WriteLine("It`s third quadrant");
            else if(points[0] > 0 && points[1] < 0) 
                Console.WriteLine("It`s fourth quadrant");
                else Console.WriteLine("координаты X или Y = 0");
