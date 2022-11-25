// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
//  убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите число строк");
int rows=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов");
int columns=Convert.ToInt32(Console.ReadLine());

int [,] GetArray(int m, int n, int min, int max)
{
    int [,] result= new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j]=new Random().Next(min,max+1);        
        }    
    }
return result;
}

void ChangArray(int [,] matrix)
{
     
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
     }
   }
 }
}

void PrintArray(int [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j]);
        }
           Console.WriteLine();
    }
}

int [,] array =GetArray(rows,columns,2,9);
PrintArray(array);
Console.WriteLine("____________________");
ChangArray(array);
PrintArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число");
int rows=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int columns=Convert.ToInt32(Console.ReadLine());

int [,] GetArray(int m, int n, int min, int max)
{
    int [,] result= new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j]=new Random().Next(min,max+1);        
        }    
    }
return result;
}

void PrintArray(int [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j]);
        }
           Console.WriteLine();
    }
}

int [,] array2 = GetArray(rows,columns,2,9);
PrintArray(array2);

int minSumLine = 0;
int sumLine = SumLineElements(array2, 0);
for (int i = 1; i < array2.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array2, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}






// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

 Console.WriteLine("Введите количество строк: ");
int row1=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите количество столбцов: ");
int columns1=Convert.ToInt32(Console.ReadLine());

 int [,] matrix1= new int [row1,columns1];

for (int i = 0; i < matrix1.GetLength(0); i++)
 {
    for (int j = 0; j < matrix1.GetLength(1); j++)
     {
         matrix1[i,j]=new Random().Next(11);
         Console.Write(matrix1[i,j]+" ");
     }
     Console.WriteLine();
 }

Console.WriteLine("____________________");


 Console.WriteLine("Введите количество строк: ");
int row2=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите количество столбцов: ");
int columns2=Convert.ToInt32(Console.ReadLine());

 int [,] matrix2= new int [row2,columns2];

for (int i = 0; i < matrix2.GetLength(0); i++)
 {
    for (int j = 0; j < matrix2.GetLength(1); j++)
     {
         matrix2[i,j]=new Random().Next(11);
         Console.Write(matrix2[i,j]+" ");
     }
     Console.WriteLine();
 }
 int[,] resultMatrix = new int[row1,columns2];

void PrintArray(int [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j]);
        }
           Console.WriteLine();
    }
}



void MultiplyMatrix(int[,] martrix1, int[,] martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martrix1.GetLength(1); k++)
      {
        sum += martrix1[i,k] * martrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
 MultiplyMatrix(matrix1,matrix2,resultMatrix);
 Console.WriteLine("__________________");
 PrintArray(resultMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

 Console.WriteLine("Введите x: ");
int x=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите y: ");
int y=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите z: ");
int z=Convert.ToInt32(Console.ReadLine());

 int [,,] matrix= new int [x,y,z];
 for (int i = 0; i < matrix.GetLength(0); i++)
 {   
    for (int j = 0; j < matrix.GetLength(1); j++)
     {     
                      
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i,j,k]=new Random().Next(10,100);      
            Console.Write( $"{matrix[i,j,k]}({i},{j},{k});  ");   
        }        
     }
     Console.WriteLine();
 }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,] matrix= new int [4,4];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

void PrintArray(int [,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j]);
        }
           Console.WriteLine();
    }
}

PrintArray(matrix);
