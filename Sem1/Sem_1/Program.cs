Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
int max = number1;
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 < number2) Console.WriteLine(number2);
else if (number1 == number2) Console.WriteLine("Числа равны."); 
else Console.WriteLine(number1);
