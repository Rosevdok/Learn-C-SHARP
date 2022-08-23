Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine());
int even = 2;
if (even > N) Console.WriteLine(even);
else 
{
    while (even < N)
    {
    Console.WriteLine(even);
    even = even + 2;
    }
}