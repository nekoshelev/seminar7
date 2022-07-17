/* Сумма четных цифр числа */

int Promt(string message)
{
System.Console.WriteLine(message);
return int.Parse(Console.ReadLine());
}
int number = Promt("Введите число > ");

int sum = 0;

int temp = number;

int count = 1;
while (temp > 0)
{
if ((temp % 10) % 2 == 0) sum = sum + temp % 10;
temp = temp / 10;

count++;

}

System.Console.WriteLine(sum);