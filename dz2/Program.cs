Console.Clear();
Console.Write("Введите первое число: ");
int a = Int32.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Int32.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Int32.Parse(Console.ReadLine());

int max = a;

if (b > max){
    max = b;
}if (c > max){
    max = c;
}
Console.Write("Максимальным числом является: ");
Console.Write(max);