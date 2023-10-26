// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10,100); // генерация рандомного числа от 10 до !99 (78)
Console.WriteLine(number); // 78
int num1 = number / 10; // 7
int num2 = number % 10; // 8
Console.WriteLine("первая цифра = " + num1 + " вторая цифра = " + num2);
if(num1 > num2)
{
    Console.WriteLine(num1);
}
else if(num2 > num1)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("цифры равны");
}