// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write($"Введите целое число: ");
int num = int.Parse(Console.ReadLine());
if (num == 0) Console.WriteLine("0 в кубе равен нулю");
for (int count = 1; count <= num; count++)
{
    double cube = Math.Pow(count, 3);
    Console.WriteLine($"{count} в кубе равно {cube}: ");
}