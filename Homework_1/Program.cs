/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] FillArray (int length, int beginBorder, int endBorder)
{
    int[] ResultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        ResultArray[i] = new Random().Next(beginBorder, endBorder);
    }
    return ResultArray;
}

void ShowArray(int[] arrayToShow)
{
    Console.Write("[");
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i < arrayToShow.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int QuantityOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {       
        if (array[i] % 2 == 0)
        {
            count++;
            
        }
    }
    return count;
}

int[] NewArray = FillArray(10, 100, 1000);
ShowArray(NewArray);
Console.WriteLine("");
int evenNumbers = QuantityOfEvenNumbers(NewArray);
Console.WriteLine($" Количество четных элементов в массиве равно {evenNumbers}");
