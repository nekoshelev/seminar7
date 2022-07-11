// Задача 1: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int number = Prompt("Введите число: ");

int count = 0;
while(number > 0)
{
    number = number /10;
    count++;
}
System.Console.WriteLine(count);
