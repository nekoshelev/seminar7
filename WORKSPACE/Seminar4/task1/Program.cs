// Задача 1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int CalcSumDigits(int number)
{
int sum = 0;
while (number >0)
{
    sum += number % 10;
    number = number / 10;
}
return sum;
}
int number = Prompt("Введите число А: ");
int result = CalcSumDigits(number);
System.Console.WriteLine($"Сумма цифр равна {result}");