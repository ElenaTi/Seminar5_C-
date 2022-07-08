/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76  */

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
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int differenceOfMaxMinIndex (int[] array)
{
    int maxElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }
    }
    int minElement = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElement)
        {
            minElement = array[i];
        }
    }
    int difference = maxElement - minElement;
    return difference;
}

int[] ResultArray = FillArray(10, 5, 200);
ShowArray(ResultArray);
Console.WriteLine("");
int diff = differenceOfMaxMinIndex(ResultArray);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {diff}.");