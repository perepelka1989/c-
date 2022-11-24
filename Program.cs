// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


 Console.WriteLine("Введите количество строк: ");
int row=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите количество столбцов: ");
int columns=Convert.ToInt32(Console.ReadLine());

 double [,] matrix= new double [row,columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-2,25)+new Random().NextDouble(); 
            matrix[i, j] = Math.Round(matrix[i,j],1);
            Console.Write(matrix[i,j]+"  ");
        }
            Console.WriteLine();
    }
        
    



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

 Console.WriteLine("Введите количество строк: ");
int row=Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите количество столбцов: ");
int columns=Convert.ToInt32(Console.ReadLine());


int [,] matrix= new int [row,columns];
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j]=i+j;
        Console.Write(matrix[i,j]+"  ");
    }
    Console.WriteLine(); 
}
Console.WriteLine("Введите номер строки: ");
int x=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int y=Convert.ToInt32(Console.ReadLine());
if (x>row || y>columns)
    {
      Console.WriteLine("   такого числа в массиве нет");
    }
    else
    {
      Console.WriteLine("_____________");
      Console.WriteLine(matrix[x,y]);
    }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] matrix= new int[3,4];
 for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i,j]=i+j;
      Console.Write(matrix[i,j]+"  ");
    }
     Console.WriteLine();
}
 
 for (int j = 0; j < 4; j++)
{
    int sum =0;
    for (int i = 0; i < 3; i++)
    {
      sum+= matrix[i,j];
    }
    Console.WriteLine($"Среднее арифметическое столбцов= {sum/3}");
}



