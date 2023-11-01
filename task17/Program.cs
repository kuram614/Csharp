// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int WorkWithUser(string message)

{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] WorkWithUser2(string message)
{
    Console.WriteLine(message);
    int[] array = new int[2];
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

// void SearchQuarter(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("I четверть");
//     }
//     else if (x < 0 && y > 0)
//     {
//         Console.WriteLine("II четверть");
//     }
//     else if (x < 0 && y < 0)
//     {
//         Console.WriteLine("III четверть");
//     }
//     else if (x > 0 && y < 0)
//     {
//         Console.WriteLine("IV четверть");
//     }
//     else
//     {
//         Console.WriteLine("Неверный ввод");
//     }
// }

void SearchQuarter2(int[] arr)
{
    if (arr[0] > 0 && arr[1] > 0)
    {
        Console.WriteLine("I четверть");
    }
    else if (arr[0] < 0 && arr[1] > 0)
    {
        Console.WriteLine("II четверть");
    }
    else if (arr[0] < 0 && arr[1] < 0)
    {
        Console.WriteLine("III четверть");
    }
    else if (arr[0] > 0 && arr[1] < 0)
    {
        Console.WriteLine("IV четверть");
    }
    else
    {
        Console.WriteLine("Неверный ввод");
    }
}

// int valueX = WorkWithUser("Введите координату X: ");
// int valueY = WorkWithUser("Введите координату Y: ");
// SearchQuarter(valueX, valueY);

// int valueX1 = WorkWithUser("Введите координату X: ");
// int valueY2 = WorkWithUser("Введите координату Y: ");
// SearchQuarter(valueX1, valueY2);

int [] arrayValue = WorkWithUser2("Введите координаты точек");
SearchQuarter2(arrayValue);

