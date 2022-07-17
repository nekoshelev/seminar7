/* Дано число 1 2 3 8 6
Найти сумму 1 * 6 + 2 * 8 + 3 * 3 */

int Promt(string message)
{
System.Console.WriteLine(message);
return int.Parse(Console.ReadLine());
}
int number = Promt("Введите число > ");

int NumberSymb(int number)
{
int c = 0;
while (number > 0)
{
number = number / 10;
c++;
}
return c;
}
int numberSymbols = NumberSymb(number);
int sum = 0;

int HighSymbol = (int)Math.Pow(10, numberSymbols - 1);
int temp = number;
int count = 1;
while (temp > 0)
{
sum = sum + (temp / HighSymbol) * (temp % 10);
System.Console.WriteLine("Первый символ " + temp / HighSymbol);
System.Console.WriteLine("Последний символ " + temp % 10);
System.Console.WriteLine("Сумма внутри цикла " + sum);
temp = temp % HighSymbol / 10;
System.Console.WriteLine(temp);
HighSymbol = HighSymbol / 100;
System.Console.WriteLine("Номер итерации" + count);
count++;

}


System.Console.WriteLine(sum);