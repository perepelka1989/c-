// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int [4];
int count=0;
    for(int i = 0; i<array.Length; i++)
    { 
        array[i]=new Random().Next(100,1000);
        Console.Write(array[i]+",");
        array[i]%=2;
    if (array[i]==0)
    {
      count++;
    }
        }
        
        Console.WriteLine("Сумма четных чисел= "+ count);
       

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [5];
int sum=0;
    for(int i = 0; i<array.Length; i++)
    { 
        array[i]=new Random().Next(0,100);
        Console.Write(array[i]+", ");
        if (i%2 != 0)
        {
           sum=sum+array[i];

        }
    }
        
        Console.WriteLine("Сумма элементов, стоящих на нечётных позициях= "+ sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int [] array = new int [5];

 for(int i = 0; i<array.Length; i++)
 { 
     array[i]=new Random().Next(-9,150);
      Console.Write(array[i]+",");
 }
 int max= array[0];
 int min= array[0];
 for (int i = 0; i < array.Length; i++)
 {
    if (array[i]>max)
    {
       max= array[i];

    }
    if (array[i]<min)
    {
       min= array[i];
       
    }
 }
Console.WriteLine($"разница между max&min равна {max-min}");