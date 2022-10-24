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

int num = new Random().Next(100,1000);
int num1 =(num/10)%10;
Console.WriteLine(num);
Console.WriteLine(num1);


// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num>99||num<-99)
{
   Console.WriteLine((num/100)%10);
}
else
{
   Console.WriteLine("третьей цифры нет");
}



// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7 включительно");
int num= Convert.ToInt32(Console.ReadLine());
if (num==6||num==7)
{
   Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет");
}
if (num>7||num<1)
{
   Console.WriteLine("ошибка");
}