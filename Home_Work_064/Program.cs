﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using System;
using static System.Console;

 static void PrintNum(int i)
        {
            Console.WriteLine(i);
            if (i == 1)
                return;
            PrintNum(i - 1);
            
        }

Console.Write("Введите число от которого начинаем: ");
            int start = int.Parse(Console.ReadLine()!);

            PrintNum(start);