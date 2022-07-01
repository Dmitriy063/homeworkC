// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Prompt(string message){
    Console.Write (message);
    int a = int.Parse (Console.ReadLine ());
    return a;
}

int n = Prompt("Введите трехзначное число N = ");
int div = 0;
if (n>99 && n<1000)
{
    div = n%100;
    System.Console.WriteLine(div/10);
}
else 
{
    System.Console.WriteLine("Число не является трехзначным");
}