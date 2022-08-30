// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int numberLength(int num)
{
    //int count = 0;
    int sum = 0;
    while (num > 0)
    {
       sum = sum + ( num % 10 );
       num = num / 10;
      //count = count + 1;
    }
    return sum;
}

Console.WriteLine(numberLength(number));