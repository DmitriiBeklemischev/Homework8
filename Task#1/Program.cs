// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
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


void GetOrderingArraiMinMax(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int n = 0; n < inArray.GetLength(1) - 1; n++)
            {

                if (inArray[i, n] < inArray[i, n + 1])
                {
                    int temp = inArray[i, n + 1];
                    inArray[i, n + 1] = inArray[i, n];
                    inArray[i, n] = temp;
                }

            }
        }
    }
}

Console.WriteLine("Введите длинну столбцов массива");
int lengthM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длинну строк массива");
int lengthN = int.Parse(Console.ReadLine());
Console.WriteLine("");

int[,] array = GetArray(lengthM, lengthN);
PrintArray(array);
GetOrderingArraiMinMax(array);
Console.WriteLine("");
Console.WriteLine("Результат работы программы :");
PrintArray(array);