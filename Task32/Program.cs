/* Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

void FillAray (int[] cal)
{
    int length = cal.Length;
    for (int i = 0; i < length; i++)
    {
        cal[i] = new Random().Next(0, 10);
    }
}

int[] GetInversion(int[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = massive[i] * -1;
    }
    
    return massive;
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
int[] array = new int[lenght];
FillAray(array);
ShowArray(array);
GetInversion(array);
ShowArray(array);
