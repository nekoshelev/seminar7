// Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int quarter = Prompt("Введите число четверти: ");

    if (quarter==1)
    {
        System.Console.WriteLine("x>0 && y>0");
    }
    else if (quarter==2)
    {
        System.Console.WriteLine("x<0 && y>0");
    }
    else if (quarter==3)
    {
        System.Console.WriteLine("x<0 && y<0");
    }
    else if (quarter==4)
    {
        System.Console.WriteLine("x>0 && y<0");
    }
    else {
        System.Console.WriteLine("Такой четверти не существует");
    }