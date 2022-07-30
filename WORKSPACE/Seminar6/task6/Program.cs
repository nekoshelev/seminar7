//Задача 4: Напишите программу, которая будет создавать копию заданного
// массива с помощью поэлементного копирования.



int[] CopyArray ( int[] array)
{
int[]array2 = new int [array.Length];
for( int i =0; i < array2.Length;i++)
{
array2[i] = array[i];
}
return array2;
}
int[] FIBarray(int number)
{
int[]array = new int [number];
array[0] = 0;
array[1] = 1;
for( int i = 2 ; i < number; i++ )
{
array[i] = array[i-1] + array[i-2];
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

int[] array = FIBarray(9);
int[] array2 = CopyArray(array);

PrintArray(array);
PrintArray(array2);