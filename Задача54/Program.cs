/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// функция получения числа 
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

// функция получения массива и заполнение ее числами
int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

// печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// функция убывания элементов каждой строки массива
void RowsArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int count = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = count;
        }
      }
    }
  }
}

int m = GetNumber("Введите кол-во строк: ");
int n = GetNumber("Введите кол-во столбцов: ");
Console.WriteLine();
int [,] array = GetArray(m, n);
PrintArray(array);
Console.WriteLine();
RowsArray(array);
PrintArray(array);
