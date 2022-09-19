/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
Console.WriteLine("Введите целое положительное число: ");
int N = int.Parse(Console.ReadLine());
int count = 4;
if (N <= 0) Console.WriteLine("Необходимо ввести целое положительное число");
if (N == 1) Console.WriteLine($"До числа {N} положительных четных чисел нет");
if (N >= 2) Console.Write("2");
while (count <= N)
{
    Console.Write(", " + count);
    count = count + 2;
}