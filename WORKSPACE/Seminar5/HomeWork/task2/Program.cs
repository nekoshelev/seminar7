// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] numbers = new int [4];
int n = numbers.Length;

FillArray(numbers);
OutputArrayString(numbers);
SumStandingElementsOddPositions(numbers);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(-50, 50);
    }
}

void OutputArrayString(int[] arrayString)
{
    string stringArray = "[";

    for (int i = 0; i < arrayString.Length; i++)
    {
        stringArray += $"{arrayString[i]}, ";
    }
    int n = stringArray.Length;
    stringArray = stringArray.Remove(n - 2, 2);
    stringArray += "]";
    Console.WriteLine($"{stringArray}");
}

void SumStandingElementsOddPositions(int[] number)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 != 0)
        {
            sum += number[i];
        }
    }
    Console.WriteLine($"Cумма чисел стоящих на нечётных позициях в массиве равна: {sum}");
}