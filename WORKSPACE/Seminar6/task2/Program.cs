// Задача 1: Напишите программу, которая принимает на вход
//три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int Promt(string message)
{
Console.Write (message);
int a = int.Parse(Console.ReadLine());
return a;
}

int A = Promt ( "enter A ");
int B = Promt ("enter B ");
int C = Promt ("enter C ");

//int summA = A + B;
//int summB =
if (A > B + C || B > A + C || C > B + A)
{
Console.WriteLine("такой треугольник не существует");
}
else Console.WriteLine(" такой треугольник существует");