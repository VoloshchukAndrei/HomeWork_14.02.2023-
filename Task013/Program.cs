﻿Console.Write("Определение третьей цифры числа - Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int result = (number / 100) % 10;

if (result == 0)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine($"{number} -> {result}");
}