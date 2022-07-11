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
int number = Prompt("Введите число А: ");
 int SumDigits(int number)
 {
    int result = number * (1+number)/2;
    return result;
 }
 int summa2 = SumDigits(number);
 System.Console.WriteLine(summa2);
