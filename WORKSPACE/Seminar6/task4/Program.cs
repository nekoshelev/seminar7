// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

int[] ConvertToBeenary(int number)
{
int[]array = new int [10];
int i = 0;
while(number > 0)
{
array[i] = number%2;
number = number / 2;
i++;
}
return array;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
System.Console.Write($"{array[i]}; ");
}
System.Console.WriteLine();
}

void ChangeEl( int[] array)
{
int i = 0;
int j = array.Length -1;
while( i < array.Length/2)
{
int temp = array[i];
array[i] = array[j];
array[j] = temp;
i++;
j--;
}

}

int[]array = ConvertToBeenary(10);
ChangeEl(array);
PrintArray(array);