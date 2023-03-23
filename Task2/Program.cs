// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

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

int SumLine(int[,] resultMatrix, int i)
{
    int sum = resultMatrix[i, 0];
    for (int j = 1; j < resultMatrix.GetLength(1); j++)
    {
        sum = sum + resultMatrix[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(resultMatrix, 0);
for (int i = 1; i < resultMatrix.GetLength(0); i++)
{
    if (sum > SumLine(resultMatrix, i))
    {
        sum = SumLine(resultMatrix, i);
        minSum = i + 1;
    }
}
Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");
