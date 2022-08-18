/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
*/

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetMinStringArray(int[,] array)
{
    int numStr = -1;
    int result = 1000;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumStr = array[i, 0];
        for (int j = 1; j < array.GetLength(1); j++)
        {

            sumStr += array[i, j];
        }

        if (sumStr < result)
        {
            result = sumStr;
            numStr = i;
        }
    }
    Console.WriteLine($"Сумма наименьшей стоки = {result}");
    Console.WriteLine($"Строка № {numStr + 1}");
}

Console.WriteLine("Введите длинну столбцов массива,");
Console.WriteLine("длинна строк будет на еденицу больше длинны столбцов");

int lengthM = int.Parse(Console.ReadLine());
int lengthN = lengthM + 1;

int[,] array = GetArray(lengthM, lengthN);
PrintArray(array);
Console.WriteLine("");
GetMinStringArray(array);