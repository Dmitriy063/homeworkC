// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int rnd(int min, int max)
{
    Random rnd = new Random();
    return rnd.Next(min, max+1);
}
int n = rnd(100, 999);
int a = 0;
int b = 0;
Console.WriteLine($"Число {n}");
while (n > 0)
{
    a = n/100;
    b = n%10;
    System.Console.WriteLine($"{a}{b}");
    return;
}

