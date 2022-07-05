// Напишите программу, которая принимает на вход 
//координаты точки (X и Y), причём X ≠ 0 или Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка.
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int x = Prompt("Введите координат X: ");
int y = Prompt("Введите координат Y: ");

if (x == 0 || y == 0)
{
    Console.WriteLine("Одно из координат находится на оси");
}
else
{
    int quarter;
    if (x > 0 && y > 0)
    {
        quarter = 1;
    }
    else if (x > 0 && y < 0)
    {
        quarter = 4;
    }
    else if (x < 0 && y > 0)
    {
        quarter = 2;
    }
    else
    {
        quarter = 3;
    }
    System.Console.WriteLine($"Точка в {quarter} четверти");
}