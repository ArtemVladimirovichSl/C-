void FillArray(int[] collection)                       //заполнение массива числами
{
    int length = collection.Length;                    //определение длинны массива
    int index = -1;                                    //позиция индекса массива по умолчанию (на консоли если элемент не найден)
    while(index < length)                              //пока индекс меньше длинны массива
    {
        collection[index] = new Random().Next(1, 10);  //заполнение массива случайными целыми числами от 1 до 10
        index++;                                       //увеличение индекса на 1
    }
}
void PrintArray(int[] col)                             //метод печати массива
{
    int count = col.Length;                            //количество элементов массива
    int position = 0;                                  //текущая позиция индекса элемента
    while(position < count)
    {
        Console.WriteLine(col[position]);              //вывод на консоль значения текущего элемента
        position++;                                    //увеличение позиции индекса элемента на 1
    }
}
int IndexOf(int[] collection, int find)                //метод возврата индекса
{
    int count = collection.Length;
    int index = 0;
    int position = 0;                                  //переменная для сохранения позиции элемента
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;                                     //остановка
        }  
        index++;
    }
    return position;                                   //возврат позиции элемента
}

int[] array = new int[10];                             //определение массива из десяти элементов

FillArray(array);                                      //заполнение массива
PrintArray(array);                                     //печать массива
Console.WriteLine();                                   //вывод пустой строки

int pos = IndexOf(array, 9);                           //результат работы IndexOf
Console.WriteLine(pos);