// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int number = Prompt("Введите число: ");
int mult = 1;
int i = 1;
while(i <= number)
{
    mult = mult * i;
    i++;
}
System.Console.WriteLine(mult);
