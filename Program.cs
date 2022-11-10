// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)

Console.WriteLine("Введите число 1");
 int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2");
 int num2 = Convert.ToInt32(Console.ReadLine());

double num = Math.Pow(num1,num2);
Console.WriteLine(num);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int SumNum(int number)
{
    int sum = 0;
 
while (number>0)
{
    sum=sum+number%10;
    number=number/10;

}
return sum;
}
Console.WriteLine("Сумма цифр равна " + SumNum(num));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = GetArray();
int[] GetArray()
{
    int []array= new int [8];

    for(int i =0; i<8;i++)
    { 
        array[i]=new Random().Next(1,1000);
        }
        return array;
}
Console.Write(String.Join(",",array));
