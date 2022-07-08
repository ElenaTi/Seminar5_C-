/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


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

int DifferenceOfMaxMinElement (int[] array)
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
    int diff = maxElement - minElement;
    return diff;
}

Console.WriteLine("Задайте длину массива.");
int length = Convert.ToInt32(Console.ReadLine());
int[] ArrayFromUser = new int[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите элемент с индексом {i}");
    ArrayFromUser[i] = Convert.ToInt32(Console.ReadLine());    
}
ShowArray(ArrayFromUser);
Console.WriteLine("");
int different = DifferenceOfMaxMinElement(ArrayFromUser);
Console.WriteLine($" Разность между максимальным и минимальным элементом массива равна {different}.");
