/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/


Console.WriteLine("Первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число: ");
int B = int.Parse(Console.ReadLine());
if (A > B) Console.WriteLine($"Число {A} больше");
else Console.WriteLine($"Число {B} больше");
