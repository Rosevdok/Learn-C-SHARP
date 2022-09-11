// Переворот массива за 1/2 прохода
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }

    return res;
}

void ReversArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}

int[] array = GetArray(9, 0, 10);
Console.WriteLine(String.Join(" ", array));

ReversArray(array);
Console.WriteLine(String.Join(" ", array));

// Перевод десятичного числа в двоичное.

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

void BinaryNumber(int num)
{
    string binar = "";
    int i = 0;
    while (num != 0)
    {
        binar = num % 2 + binar;
        num = num / 2;
        i++;
        if (i % 4 == 0) binar = " " + binar;
    }

    Console.WriteLine(binar);
}

BinaryNumber(num);

//
int number = int.Parse(Console.ReadLine());

string res1 = Convert.ToString(number, 2);
string res2 = DecToNum(number, 2);

Console.WriteLine($"{number}->{res1}");

// Универсальный математический для перевода из 10 в любую
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}

// Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Write("Введите число a: ");
int num_a = Console.ReadLine();
Console.Write("Введите число b: ");
int num_b = Console.ReadLine();
Console.Write("Введите число c: ");
int num_c = Console.ReadLine();

void Contr(int num_a, int num_b, int num_c);

void Contr(int A, int B, int C);
{
    switch (A, B, C)
    {
        case A > B + C:
            {
                Console.Write("Треугщльнтк возможен.");
                break;
            }
        case B > A + C:
            {
                Console.Write("Треугщльнтк возможен.");
                break;
            }
        case C > A + B:
            {
                Console.Write("Треугщльнтк возможен.");
                break;
            }
        default: Console.Write("Треугщльнтк невозможен!!!");
    }
}

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int c = int.Parse(Console.ReadLine());

if (c < a + b & a < b + c & b < a + c)
{
    Console.WriteLine("Он существует)))");
}
else
{
    Console.WriteLine("Он не существует(((");
}

// Второйвыриант через строку

string[] st = Console.ReadLine().Split(' ');
bool IsTriangle(int a, int b, int c)
{
    return (((a + b) > c) && ((a + c) > b) && ((b + c) > a));
}
Console.WriteLine(IsTriangle(int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2])));

// Или

string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
bool IsTriangle(int a, int b, int c) { return (((a + b) > c) && ((a + c) > b) && ((b + c) > a)); }
Console.WriteLine(IsTriangle(int.Parse(st[0]), int.Parse(st[1]), int.Parse(st[2])));