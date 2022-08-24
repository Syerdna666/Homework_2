// Task_1
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void GetSecondDigit(int number)
{
    if ((number >= 100 && number < 1000) | (number <= -100 && number > -1000))
    {
        System.Console.WriteLine(Math.Abs((number % 100) / 10));
    }
    else
    {
        System.Console.WriteLine("Введите трехзначное число");
    }
}

GetSecondDigit(832);


