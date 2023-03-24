// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n]; // Матрица: m строк и n столбцов
    for (int i = 0; i < m; i++) // m = matrix.GetLenth(0) - строчки
    {
        for (int j = 0; j < n; j++) // n = matrix.GetLenth(1) - столбцы
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] matrixA = FillMatrix(3, 3, 0, 10);
int[,] matrixB = FillMatrix(3, 3, 0, 10);

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы
        {
            Console.Write(array[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
        }
        Console.WriteLine(); // Переход на новую строчку
    }
}
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
PrintMatrix(MultMatrix(matrixA, matrixB));
int[,] MultMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {

                resultMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
        }
    }
    return resultMatrix;
}