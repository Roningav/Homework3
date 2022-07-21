/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
int FirstFunction(string message)
{
    int result = 0;
    string error = "Введите корректное число, пожалуйста!";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
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

void Sqrt(int number)
{
    for (int i = 1; i < number; i++)
    {
        Console.WriteLine(Math.Pow(i,2));
    }
}

int number = FirstFunction("Введите число: ");
Sqrt(number);
*/
int FirstFunction(string message)
{
    int result = 0;
    string error = "Введите корректное число, пожалуйста!";

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
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

void Sqrt(int number)
{
    for(int i = 1; i < number; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
int number = FirstFunction("Введите число: ");
Sqrt(number);

