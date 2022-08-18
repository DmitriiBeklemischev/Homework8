// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2


void GetArray3(int[,,] result)
{
    int[] array = new int[result.GetLength(0) * result.GetLength(1) * result.GetLength(2)];
    int num;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 100);
        num = array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 100);
                    j = 0;
                    num = array[i];
                }
                num = array[i];
            }
        }
    }
    int c = 0;
    for (int x = 0; x < result.GetLength(0); x++)
    {
        for (int y = 0; y < result.GetLength(1); y++)
        {
            for (int z = 0; z < result.GetLength(2); z++)
            {
                result[x, y, z] = array[c];
                c++;
            }
        }
    }
}
void PrintArray(int[,,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
  {
    for (int j = 0; j < array3.GetLength(1); j++)
    {
      for (int k = 0; k < array3.GetLength(2); k++)
      {
        Console.Write($"{array3[i,j,k]}({i},{j},{k})");
      }
      Console.WriteLine();
    }
  }
}

Console.WriteLine("Введите первую длинну трехмерного массива");
int lengthX = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую длинну трехмерного массива");
int lengthY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью длинну трехмерного массива");
int lengthZ = int.Parse(Console.ReadLine());
Console.WriteLine("");
int[,,] array3 = new int[lengthX, lengthY, lengthZ];

GetArray3(array3);

PrintArray(array3);
