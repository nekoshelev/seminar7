// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int x1 = Prompt("Введите число x1: ");
int x2 = Prompt("Введите число x2: ");
int y1 = Prompt("Введите число y1: ");
int y2 = Prompt("Введите число y2: ");

double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));
System.Console.WriteLine(result);