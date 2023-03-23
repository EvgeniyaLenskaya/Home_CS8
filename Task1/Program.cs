// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resultMatrix = FillMatrix(rows, columns, 0, 10);
int[,] FillMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
PrintMatrix(resultMatrix);
Console.WriteLine();
OrderLines(resultMatrix);
PrintMatrix(resultMatrix);

void OrderLines(int[,] orderMatrix)
{
  for (int i = 0; i < orderMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < orderMatrix.GetLength(1); j++)
    {
      for (int k = 0; k < orderMatrix.GetLength(1) - 1; k++)
      {
        if (orderMatrix[i, k] < orderMatrix[i, k + 1])
        {
          int temp = orderMatrix[i, k + 1];
          orderMatrix[i, k + 1] = orderMatrix[i, k];
          orderMatrix[i, k] = temp;
        }
      }
    }
  }
}



