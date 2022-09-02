// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
double numA = Double.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

Zadacha25 (numA, numB);

void Zadacha25(double number, int degree)
{
    if (number == 0)
    {
        Console.WriteLine ("Результат = 0.");
        return;
    } 
    else if (degree == 0)
    {
        Console.WriteLine ("Результат = 1.");
        return;
    }   
    double res = number;
    for (int i = 1; i < degree; i++)
    {
       res *= number; 
    }

    
    Console.WriteLine($"Число {number} в степени {degree} равно {res}"); 
}
    
 

