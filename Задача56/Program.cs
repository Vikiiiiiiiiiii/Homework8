/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

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

// нахождение строки с наименьшей суммой элементов
int GetSumm (int [,] array)
{
    int rows = 0;
    int minsum = 0;
    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minsum = minsum + array[0,i];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          summ = summ + array[i,j];
        }
        if (minsum > summ)
        {
          minsum = summ;
          rows = i;
        }
    }
    return rows;
}

int m = GetNumber("Введите кол-во строк: ");
int n = GetNumber("Введите кол-во столбцов: ");
Console.WriteLine();
int [,] array = GetArray(m, n);
PrintArray(array);
int number = GetSumm(array);
Console.WriteLine($"Строка с наименьшей суммой элементов -> {number}");


