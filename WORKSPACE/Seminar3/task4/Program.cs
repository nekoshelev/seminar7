// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

// int Prompt(string message)
// {
//     Console.Write(message);
//     int a = int.Parse(Console.ReadLine());
//     return a;
// }

// int n = Prompt("Введите число N: ");
// int count = 0;
// while(count <= n)
// {
//     Console.Write(count * count + " ");
//     count++;
// }
int Prompt(string message)
{
Console.Write(message);
int a = int.Parse(Console.ReadLine());
return a;
}

int Pow(int a, int b)
{
int result = 1;
int count = 1;
while (count <= a)
{
result = result * a;
count++;
}
return (result);
}

int N = Prompt(" add number => ");

int count = 1;
;


while (count <= N)
{
Console.Write(Pow(count, count) + " ");
count++;
}