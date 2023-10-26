Console.Clear();
Console.Write("Введите число: ");
int x = Int32.Parse(Console.ReadLine());

if (x % 2 == 0){
    Console.Write("Число четное");
}else{
    Console.Write("Число нечетное");
}