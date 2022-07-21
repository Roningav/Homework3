/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
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

void Result(int number)
{
    int number1 = number/10000;
    int number2 = (number/1000)%10;
    int number3 = (number/100)%10;
    int number4 = (number/10)%10;
    int number5 = number%10;
    if (number1 == number5 && number2 == number4)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else if(number<10000)
    {
        Console.WriteLine($"Число {number} содержит меньше пяти элементов");
    }
    else if(number>100000)
    {
        Console.WriteLine($"Число {number} содержит больше пяти элементов");
    }
    else 
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
int number = FirstFunction("Введите целое пятизначное число: ");
Result(number);

