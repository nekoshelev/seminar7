// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Promt(string message)
{
System.Console.WriteLine(message);
return int.Parse(Console.ReadLine());
}
int n = Promt("Введите число > ");
int sum = 0;

while (n > 0)
{
int number = n % 10;
n = n / 10;
sum = sum + number;
}

System.Console.WriteLine(sum);
