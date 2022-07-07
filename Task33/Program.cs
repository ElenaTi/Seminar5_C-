/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

void FillAray (int[] cal)
{
    int length = cal.Length;
    for (int i = 0; i < length; i++)
    {
        cal[i] = new Random().Next(0, 3);
    }
}

bool GetIndexOf(int[] array, int find)
{
    bool isInArray = false;
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (array[i] == find)
        {
           isInArray = true;
           break;
        }                
    }
    return isInArray;
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

Console.WriteLine("Введите длину массива.");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число для проверки.");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
FillAray(array);
ShowArray(array);
bool isInArray = GetIndexOf(array, number);
if (isInArray)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

