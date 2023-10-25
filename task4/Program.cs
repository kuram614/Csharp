// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
int N = - number;

while (N <= number){
    Console.Write(N + ", ");
    N++;
}if (N == number){
    Console.Write(N);
}