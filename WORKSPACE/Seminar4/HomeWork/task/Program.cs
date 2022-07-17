// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine ());
    return a;
}
int a = Prompt("Введите A: ");
int b = Prompt("Введите B: ");

int degree = a;

for (int i = 1; i < b; i++)
{
degree = degree * a;
}
Console.WriteLine($"{a} в {b} степени равно: {degree}");