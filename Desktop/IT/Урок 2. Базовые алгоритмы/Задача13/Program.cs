// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int Text (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdFigure(int number)
{
    while (number>999)
    {
        number = number/10;
    }
    return number % 10;
}

bool NumberCheck(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("Третьей цифры нет!");
        return false;
    }
    return true;
}

int number = Text("Введите число > ");
if (NumberCheck(number))
{
    System.Console.WriteLine(GetThirdFigure(number));
}

