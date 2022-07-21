/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int FirstFunction(string message)
{
    int result = 0;
    string error = "Введите корректное число, пожалуйста!";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) // int выводиm
        {
            break;
        }
        else 
        {
            Console.Clear();
            Console.WriteLine(error);
        }
    }

    return result;
}

int x1 = FirstFunction("Введите координату x первой точки: ");
int y1 = FirstFunction("Введите координату y первой точки: ");
int c1 = FirstFunction("Введите координату с первой точки");
int x2 = FirstFunction("Введите координату x второй точки: ");
int y2 = FirstFunction("Введите координату y второй точки: ");
int c2 = FirstFunction("Введите координату с второй точки");

double length = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2)+ Math.Pow(c2-c1,2));
Console.WriteLine($"Расстояние между точками: {length} ");

