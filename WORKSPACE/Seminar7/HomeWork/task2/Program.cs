// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int rows = Prompt("Введите номер строки > ");
int columns = Prompt("Введите номер столбца > ");
int [,] numbers = new int [10,10];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if (rows > numbers.GetLength(0) || columns > numbers.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"На {rows}-й строке и в {columns}-м столбце находится число: {numbers[rows-1,columns-1]}");
}


void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 9);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}