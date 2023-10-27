// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number % 7;
int num2 = number % 23;

if (num1 == 0 && num2 == 0)
{
    Console.Write("yes");
}
else
{
    Console.Write("no");
}