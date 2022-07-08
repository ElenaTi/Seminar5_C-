/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */

int[] FillArray (int length, int startBorder, int finishBorder)
{
    int[] NewArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        NewArray[i] = new Random().Next(startBorder, finishBorder);
    }
    return NewArray;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length -1)
        {
            Console.Write(", ");
        }       
    }
     Console.Write("]");
}

int SumOfElementsOnEvenPosition (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];            
        }
    }
    return sum;
}

int[] ArrayForTask = FillArray(10, 0, 20);
ShowArray(ArrayForTask);
Console.WriteLine("");
int Summa = SumOfElementsOnEvenPosition(ArrayForTask);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {Summa}.");