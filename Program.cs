// Задача1. Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

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

//  Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1");
 int number1 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите число 2");
 int number2 = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите число 3");
 int number3 = Convert.ToInt32(Console.ReadLine());

 int max= number1;
 if (number2>max)
 {
    Console.WriteLine(max= number2);
 }
 else
 {
    Console.WriteLine(max= number1);
 }
 if (number3>max)
 {
    Console.WriteLine(max= number3);
 }
 