// Задайте двумерный массив. Введите элемент,
//и найдите первое его вхождение, выведите позиции по горизонтали
//и вертикали, или напишите, что такого элемента нет.
//Например, такой массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Введенный элемент 2, результат: [1, 4]

//Введенный элемент 6, результат: такого элемента нет.
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answer;
}
VRyzhkov: void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

void FindEll(int[,] array, int A) // нам надо добавить эллимент для поиска
{
    bool isFind = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] == A)
            {
                isFind = true;
                Console.WriteLine($"{i + 1},{j + 1}");
                //return;
            }
    }
    if (!isFind)
    {
        Console.WriteLine(" нет такого элемента ");
    }
}

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("введите количество столбцов > ");
int[,] myArray = GenerateArray(rows, columns, -10, 10);
PrintArray(myArray);
int A = Prompt("Введите искомое число > ");

FindEll(myArray, A);