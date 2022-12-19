/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20       2*3+4*3 = 18             2*4+4*3 = 20
15 18       3*3+2*3 = 15             3*4+2*3 = 18
*/

int GetNumber(string text) 
{     
    int result = 0;     
     
    while(true)     
    {        
        Console.WriteLine(text); 
        if (int.TryParse(Console.ReadLine(), out result))         
        {             
            break;         
        }         
        else         
        {             
            Console.WriteLine("Ввели не число");         
        }     
    }     
    return result; 
}

void FillArray1(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
}

void FillArray2(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i,j]}  ");
    }
    Console.WriteLine();
  }
}

void ProductMatrix(int[,] matrix1, int[,] matrix2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      result[i,j] = sum;
    }
  }
}

int m = GetNumber("Введите число строк 1-й матрицы: ");
int n = GetNumber("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = GetNumber("Введите число столбцов 2-й матрицы: ");
Console.WriteLine();

int[,] matrix1 = new int[m, n];
FillArray1(matrix1);
FillArray2(matrix1);
Console.WriteLine();

int[,] matrix2 = new int[n, p];
FillArray1(matrix2);
FillArray2(matrix2);
Console.WriteLine();

int[,] result = new int[m,p];

ProductMatrix(matrix1, matrix2, result);
Console.WriteLine($"Произведение двух матриц: ");
FillArray2(result);

