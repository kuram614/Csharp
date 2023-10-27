// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100,1000); // генерация рандомного числа от 100 до !999 (781)
Console.WriteLine("Рандомное число: " + number); // 78
int num1 = number / 10; // 7
int num2 = number / 100; // 8
int num3 = number % 10;
number = (num2*10 + num3);
Console.WriteLine(number); // 78