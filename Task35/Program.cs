/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

void FillAray (int[] cal)
{
    int length = cal.Length;
    for (int i = 0; i < length; i++)
    {
        cal[i] = new Random().Next(0, 200);
    }
}

void ShowArray(int[] arrayToShow)
{
    Console.Write("[");
     for (var i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write(arrayToShow[i]);
        if (i < arrayToShow.Length - 1)
        {
             Console.Write(", ");
        }
    }
     Console.WriteLine("]");
}

int GetCountOFNumbers(int[] array, int beginNumber, int endNumber)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > beginNumber && array[i] < endNumber)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.WriteLine("Введите длину массива.");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Начальное значение интервала.");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Конечное значение интервала.");
int number2 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
FillAray(array);
ShowArray(array);
int result = GetCountOFNumbers(array, number1, number2);
Console.WriteLine(result);