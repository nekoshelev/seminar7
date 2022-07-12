/* Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */
int RandomNum(int min, int max)
{
int a = new Random().Next(min, max + 1);
return a;
}

int[] NewArray(int length, int min, int max)
{
int[] arr = new int[length];
int i = 0;
while (i < length)
{
arr[i] = RandomNum(min, max);
i++;
}
return arr;
}

void Print(int[] array)
{
System.Console.Write("[");
System.Console.Write(array[0]);
for (int i = 1; i < array.Length; i++)
{
System.Console.Write(", " + array[i]);
}
System.Console.WriteLine("]");
}

int[] array1 = NewArray(8, 0, 1);
Print(array1);