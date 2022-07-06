// Задача 2

//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int x1 = Prompt("Введите число A1: ");
int y1 = Prompt("Введите число A2: ");
int z1 = Prompt("Введите число A3: ");
int x2 = Prompt("Введите число B1: ");
int y2 = Prompt("Введите число B2: ");
int z2 = Prompt("Введите число B3: ");


double result = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
System.Console.WriteLine(result);
