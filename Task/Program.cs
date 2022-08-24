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


// Task_2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void GetThirdDigit(int number)
{
    if (number > 99)
    {
        System.Console.WriteLine(number.ToString()[2]);
    }
    else
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
}

GetThirdDigit(32679);