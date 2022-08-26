Console.Write("Введите цифрой день недели от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if (day > 5)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}