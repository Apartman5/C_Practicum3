﻿// Задача №18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти");
int a = Convert.ToInt32(Console.ReadLine());
switch(a)// альтернативный вариант записи условия switch(true), тогда
{
case 1:// здесь можно вводить несколько перменных в виде: case a == 1 && b == 2 && и т.д.
        // тогда switch будет искать совпадения с условием true
{
    Console.WriteLine("X и Y- от нуля до +бесконечности");
    break;
}
case 2:
{
    Console.WriteLine("Y- от нуля до +бесконечности, X - от нуля до -бесконечности");
    break;
}
case 3:
{
    Console.WriteLine("X и Y- от нуля до -бесконечности");
    break;
}
case 4:
{
    Console.WriteLine("X - от нуля до +бесконечности, Y - от нуля до -бесконечности");
    break;
}
default:
{
    Console.WriteLine("Вы ввели неправильное число!");
    break;
}
}