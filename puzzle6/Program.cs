/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/
Console.WriteLine("Введите число: ");
int numb = int.Parse(Console.ReadLine());
if (numb % 2 == 0) Console.WriteLine("Вы ввели четное число");
else Console.WriteLine("Вы ввели НЕчетное число ");