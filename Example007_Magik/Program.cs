Console.Clear(); // очистка терминала
Console.SetCursorPosition(10, 4); // отступы от краев поля в символах (столбцов, строк)
Console.WriteLine("*");

int xa = 40, ya = 1,   // определяем вершину треугольника
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");


int x = xa, y = xb; // определили случчайную первую точку

int count = 0; // установили счетчик

while(count < 10000) // условие для остановки счетчика
{
    int what = new Random().Next(0, 3); // сгенерировать случайное число [0;3) 0 1 2 (полуинтервал)
    if(what == 0) // проверка
    {
        x = (x + xa) / 2; // задаём середину отрезка
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count = count + 1; // коротко count++

}