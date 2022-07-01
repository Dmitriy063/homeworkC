// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Prompt(string message){
    Console.Write (message);
    int a = int.Parse (Console.ReadLine ());
    return a;
}

int n = Prompt("Введите цифру обозначающую день недели: ");
if (n == 6 || n == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (n < 1 || n > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("этот день не выходной");

