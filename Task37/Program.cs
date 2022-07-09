/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21] */

 int[] FillArray (int length, int beginBorder, int endBorder)
{
    int[] NewArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        NewArray[i] = new Random().Next(beginBorder, endBorder);
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

int[] CompositionOfCoupleElements(int[] array)
{    
    // int length2 = Math.Ceiling(array.Length / 2);
    int length2 = (int)Math.Ceiling(array.Length / 2.0);
    /* int length2 = 0;
    if (array.Length % 2 > 0)
    {
        length2 = array.Length / 2 + 1;
    }    
    else
    {
        length2 = array.Length /2;
    } */
    int[] array2 = new int[length2];
   for (int i = 0; i < array2.Length; i++)
    {      
        if (array.Length % 2 > 0 && i == array2.Length -1)
        {            
            array2[i] = array[i];
        }
        else
        {
            array2[i] = array[i] * array[array.Length -1  - i];   
        }    
    } 
    return array2;
}

int[] ResultArray = FillArray(5, 1, 6);
ShowArray(ResultArray);
Console.WriteLine("");
int[] CompositionArray = CompositionOfCoupleElements(ResultArray);
ShowArray(CompositionArray); 
