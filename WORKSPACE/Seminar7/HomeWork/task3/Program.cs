// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("Введите количество столбцов > ");
Console.Write("Среднее арифметическое каждого столбца: ");
int[,] numbers = new int[rows, columns];
FillArrayRandomNumbers(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double arif = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        arif = (arif + numbers[i, j]);
    }
    arif = arif / rows;
    Console.Write(arif + "; ");
}
Console.WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}