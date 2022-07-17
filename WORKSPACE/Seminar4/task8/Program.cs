/* Вводим строку вручную затем убираем пробелы */

string Promt(string msg)
{
System.Console.WriteLine(msg);
string text = Console.ReadLine();
return text;
}

string RemoveSpaces(string text)
{
string result = String.Empty;
for (int i = 0; i < text.Length; i++)
{
if (text[i] != ' ')
{
result = result + text[i];
}
}
return result;
}
string newtext = RemoveSpaces(Promt("Введите текст: "));
System.Console.WriteLine(newtext);

bool IfPalindrome(string newtext)
{
int i = newtext.Length - 1;
int j = 0;

while (i > j)
{
if (newtext[i] != newtext[j])
{
return false;
}
i--;
j++;
}
return true;
}

if (!IfPalindrome(newtext)) System.Console.WriteLine("Фраза не является палиндромом!");
else System.Console.WriteLine("Фраза является палиндромом!");