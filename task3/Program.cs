// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Укажите порядковый номер дня недели: ");
int numDay = Int32.Parse(Console.ReadLine());
string name = "Такого дня недели не существует";

if (numDay == 1){
    name = "Понедельник";
}else if (numDay == 2){
    name = "Вторник";
}else if (numDay == 3){
    name = "Среда";
}else if (numDay == 4){
    name = "Четверг";
}else if (numDay == 5){
    name = "Пятница";
}else if (numDay == 6){
    name = "Суббота";
}else if (numDay == 7){
    name = "Воскресенье";
}

Console.Write(name);
