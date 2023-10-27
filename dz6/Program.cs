// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = number / 10 % 10;

if(number < 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Введенное число: " + number);
    Console.WriteLine("Вторая цифра: " + secondDigit);
}