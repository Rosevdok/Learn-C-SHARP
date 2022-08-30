// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
double numA = Double.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
double numB = Double.Parse(Console.ReadLine());
//Console.WriteLine($"{numA}   {numB}");

Zadacha25 (numA, numB);

void Zadacha25(double number, double degree)
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
    

    double rez = Math.Pow(number, degree);
    Console.WriteLine($"Число {number} в степени {degree} равно {rez}"); 
}
    
 

