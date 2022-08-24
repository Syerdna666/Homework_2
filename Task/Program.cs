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
    if ((number > 99) | (number < -99))
    {
        number = Math.Abs(number);
        System.Console.WriteLine(number.ToString()[2]);
    }
    else
    {
        System.Console.WriteLine("Третьей цифры нет");
    }
}

GetThirdDigit(-336679);


// Task_3
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void ChekWeekend(int day)
{
    if (day > 0 && day <= 7)
    {
        if (day == 6 || day == 7)
        {
            System.Console.WriteLine("Да");
        }
        else
        {
            System.Console.WriteLine("Нет");
        }
    }
    else{
        System.Console.WriteLine("Введите существующий день недели");
    }

}

ChekWeekend(6);

