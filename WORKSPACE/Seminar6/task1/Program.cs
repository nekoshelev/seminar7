// Задача 1: Напишите программу, которая перевернёт одномерный массив
//  (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GenerateArray(int length = 10, int min = 1, int max = 5)
{
int[] newArray = new int[length];
Random rnd = new Random();
for (int i = 0; i < newArray.Length; i++)
{
newArray[i] = rnd.Next(min, max + 1);
}
return newArray;
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

int [] array = GenerateArray();
PrintArray(array);
ChangeEl(array);
PrintArray(array);