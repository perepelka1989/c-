// // Задача1. Напишите программу, которая на вход принимает два числа 
// // и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 ->  max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число 1");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число 2");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int max=number1;
// if (number1>number2)
// {
//     Console.WriteLine("первое число максимальное");
// }
// else
// {
//     Console.WriteLine("второе число максимальное");
// }



// //  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// Console.WriteLine("Введите число 1");
//  int number1 = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine("Введите число 2");
//  int number2 = Convert.ToInt32(Console.ReadLine());

//  Console.WriteLine("Введите число 3");
//  int number3 = Convert.ToInt32(Console.ReadLine());

//  int max= number1;
//  if (number2>max)
//  {
//     Console.WriteLine(max= number2);
//  }
//  else
//  {
//     Console.WriteLine(max= number1);
//  }
//  if (number3>max)
//  {
//     Console.WriteLine(max= number3);
//  }
 


// //   Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// //   является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// Console.WriteLine("Введите число");
//  int number = Convert.ToInt32(Console.ReadLine());

//  if (number%2==0)
//  {
//     Console.WriteLine("число четное");
//  }
//  else
//  {
//     Console.WriteLine("число нечетное");
//  }

// // Задача 8: Напишите программу, которая на вход принимает число (N), 
// // а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число");
//  int number = Convert.ToInt32(Console.ReadLine());
// int i=2;

//  while (i<=number)
//  {
//     Console.WriteLine(i);
//     i=i+2;
//  }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100,1000);
// int num1 =(num/10)%10;
// Console.WriteLine(num);
// Console.WriteLine(num1);


// // Задача 13: Напишите программу, которая выводит третью цифру 
// // заданного числа или сообщает, что третьей цифры нет.
// // 645 -> 5
// // 78 -> третьей цифры нет
// // 32679 -> 6

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num>99||num<-99)
// {
//    Console.WriteLine((num/100)%10);
// }
// else
// {
//    Console.WriteLine("третьей цифры нет");
// }



// // Задача 15: Напишите программу, которая принимает на вход цифру,
// //  обозначающую день недели, и проверяет, является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // 1 -> нет

// Console.WriteLine("Введите число от 1 до 7 включительно");
// int num= Convert.ToInt32(Console.ReadLine());
// if (num==6||num==7)
// {
//    Console.WriteLine("да");
// }
// else
// {
//    Console.WriteLine("нет");
// }
// if (num>7||num<1)
// {
//    Console.WriteLine("ошибка");
// }

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5значное число");
int num = Convert.ToInt32(Console.ReadLine());

int a = num/10000;
int b = (num/1000)%10;
int c = (num/100)%10;
int d = (num/10)%10;
int e = num%10;
if (a==e&&b==d)
{
    Console.WriteLine("число является палиндромом");
}
else
{
    Console.WriteLine("число не является палиндромом");
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите число");
int X1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int X2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int Y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int Z2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2)+Math.Pow(Z1-Z2,2));

Console.WriteLine(d);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

for (int i=1; i < N; i++)
{
   int num = i*i*i;

 Console.WriteLine(num);
    
 }
