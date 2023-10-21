﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Некорректный ввод!");
    return;
}

int result = SumNaturalNumbers(numberM, numberN);
Console.WriteLine($"M = {numberM}; N = {numberN} -> {result}");

int SumNaturalNumbers(int numM, int numN)
{
    if (numM < numN)
    {
        return numM + SumNaturalNumbers(numM + 1, numN);
    }
    else if (numM > numN)
    {
        return numM + SumNaturalNumbers(numM - 1, numN);
    }
    else return numM;
}