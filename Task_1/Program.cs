/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Write("Введите число a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
var num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
    Console.WriteLine($"Так как {num1} > {num2}, максимальное: {num1}");
else 
    Console.WriteLine($"Так как {num2} > {num1}, максимальное: {num2}");