// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

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

Console.WriteLine("Введите длинну столбцов массива");
Console.WriteLine("<<второй массив будет задан с тем же размером>>");
int lengthM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длинну строк массива");
int lengthN = int.Parse(Console.ReadLine());
Console.WriteLine("");

int[,] firstMartrix = GetArray(lengthM, lengthN);

int[,] secomdMartrix = GetArray(lengthM, lengthN);

PrintArray(firstMartrix);
Console.WriteLine("");
PrintArray(secomdMartrix);
Console.WriteLine("");

int[,] resultMatrix = new int[lengthM, lengthN];

Console.WriteLine("");
Console.WriteLine("результат умножения матриц:");
Console.WriteLine("");

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
PrintArray(resultMatrix);
