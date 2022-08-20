int a = 1; // = - оператор присваивания
int b = 2;
int c = 6; // вводим данные
int d = 8;
int e = 4;

int max = a; // за максимум берем значение первой гири

if (a > max) max = a; // если значение а больше максимума, то а - максимум
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max); // вывод значения max на экран