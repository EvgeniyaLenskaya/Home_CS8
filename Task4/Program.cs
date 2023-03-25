// Задача 60. Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = 2;
int n = 2;
int p = 2;
int[,,] result3DMatrix = FillMatrix3D(m, n, p, 10, 100);
int[,,] FillMatrix3D(int m, int n, int p, int min, int max)
{
    int[,,] matrix3D = new int[m, n, p];
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i,j,k] = new Random().Next(min, max);
            }

        }
    }
    return matrix3D;   
}
void Print3DMatrix(int[,,] input3DMatrix)
{
    for (int i = 0; i < input3DMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < input3DMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < input3DMatrix.GetLength(2); k++)
            {
                Console.Write($"{input3DMatrix[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }       
    }
}
Print3DMatrix(result3DMatrix);