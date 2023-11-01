// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Input(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double Dist(int ax, int ay, int bx, int by)
{
    double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
    return result;
}

int ax = Input("Введите Ax: "),
    ay = Input("Введите Ay: "),
    bx = Input("Введите Bx: "),
    by = Input("Введите By: ");

System.Console.WriteLine($"Distance beetwen = {Math.Round(Dist(ax, ay, bx, by),2)}"); 
