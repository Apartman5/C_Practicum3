﻿// Задача №22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// Примеры:
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4// 

Console.WriteLine("введите целое число N");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for(int i = 1; i <= number; i ++)// начало цикла; конец цикла; шаг цикла;
    {
        Console.Write(i*i + "\t");// \t - форматирование строки через tab
    }
}
else Console.WriteLine("Вы ввели неправильное число");