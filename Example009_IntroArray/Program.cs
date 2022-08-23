int Max(int arg1, int arg2, int arg3)  // функция Max с возвратом числа (int)
{
    int result = arg1;                         // тело метода
    if(arg2 > result) result = arg2;                        // КОД ПОИСКА MAX ИЗ ТРЁХ
    if(arg3 > result) result = arg3;
    return result;                     // возврат результата
}           //  0   1   2   3   4   5   6   7   8
int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};          // определяем массив
array[5] = 12;                       // присвоение (изменение) значения элементу массива

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.Write("Максимальное число - ");
Console.WriteLine(result);