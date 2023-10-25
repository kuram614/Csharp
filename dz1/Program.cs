Console.Clear();
Console.Write("Введите первое число: ");
int a = Int32.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Int32.Parse(Console.ReadLine());

int max = a;
int min = b;

if (a > b){
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(max);
    Console.WriteLine("Минимальное число: ");
    Console.WriteLine(min);
}else if (a < b){
    Console.WriteLine("Максимальное число: ");
    Console.WriteLine(min);
    Console.WriteLine("Минимальное число: ");
    Console.WriteLine(max);
}
