﻿// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Input(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool ValidateInput(int quarter)
{
    return (quarter >= 1 && quarter <= 4) ? true : false;
}

string getRange(int quarter)
{
    string answer = "";

    if (quarter == 1)
    {
    answer = "x = (0, +inf), y = (0, +inf)";
    }
    else if (quarter == 2)
    {
    answer = "x = (-inf, 0), y = (0, +inf)";
    }
    else if (quarter == 3)
    {
    answer = "x = (-inf, 0), y = (-inf, 0)";
    }
    else if (quarter == 4)
    {
    answer = "x = (0, +inf), y = (-inf, 0)";
    }
    return answer;
    
}

int quarter = 0;
while (true)
{
    quarter = Input("Введите номер четверти: ");
    if (ValidateInput(quarter)) break;
    System.Console.WriteLine("Вы ввели некорретный номер: ");
}

System.Console.WriteLine(getRange(quarter));