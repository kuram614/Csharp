﻿// Задача 10: Напишите программу,
// которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int secondDigit = number / 10 % 10;

// if(number < 100 || number >= 1000)
// {
//     Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
//     return;
// }
// else
// {
//     Console.WriteLine("Введенное число: " + number);
//     Console.WriteLine("Вторая цифра: " + secondDigit);
// }

int Promt(string meassage)
{
    System.Console.Write(meassage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Promt("Введите трехзначное число: ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine($"Введенное число `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра `{secondRank}`");