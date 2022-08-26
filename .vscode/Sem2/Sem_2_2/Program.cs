// На входе число 645
int Num = 645;
int Rez = 0;
if (Num / 100 < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{ 
    do
    {
        Rez= Num % 10;
        Num = Num / 10;
    }    
    while (Num / 100 >= 1);
    Console.WriteLine(Rez);
}

// На входе число 78
Num = 78;
Rez = 0;
if (Num / 100 < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{ 
    do
    {
        Rez= Num % 10;
        Num = Num / 10;
    }    
    while (Num / 100 >= 1);
    Console.WriteLine(Rez);
}

// На входе число 32679
Num = 32679;
Rez = 0;
if (Num / 100 < 1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{ 
    do
    {
        Rez= Num % 10;
        Num = Num / 10;
    }    
    while (Num / 100 >= 1);
    Console.WriteLine(Rez);
}