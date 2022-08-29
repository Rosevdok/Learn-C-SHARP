// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int remains = 0;

void NamDig()
{
    remains = number % 10;
    number = number / 10;
}

NamDig();
int a1 = remains;
NamDig();
int a2 = remains;
NamDig();
int a3 = remains;
NamDig();
int a4 = remains;
NamDig();
int a5 = remains;

if(a1 == a5 & a2 == a4)
{
    Console.WriteLine("Число является паллиндромом");
}
else 
{
    Console.WriteLine("Число не является паллиндромом");
}