﻿/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/
Console.WriteLine("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numb3 = int.Parse(Console.ReadLine());
int max = numb1;
if (numb2 > max) max = numb2;
if (numb3 > max) max = numb3;
Console.WriteLine($"Число {max} является наибольшим из введенных");