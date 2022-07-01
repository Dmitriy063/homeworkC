// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Prompt(string message){
    Console.Write (message);
    int a = int.Parse (Console.ReadLine ());
    return a;
}

int n = Prompt("Введите трехзначное число N = ");
int a = 0;
a = n%10;
if (n>99 && a>0)
{
    System.Console.WriteLine(a);
}
else {
    System.Console.WriteLine("Третьей цифры нет");
}