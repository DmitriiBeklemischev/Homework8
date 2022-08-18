// Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:

int n = 4;
int[,] array = new int[n, n];

int k = 1;
int i = 0;
int j = 0;

while (k <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = k;
  k++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(array);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

