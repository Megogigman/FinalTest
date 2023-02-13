//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1 : {
        System.Console.WriteLine("Будний день");
        break;
    }
    case 2 : {
        System.Console.WriteLine("Будний день");
        break;
    }
    case 3 : {
        System.Console.WriteLine("Будний день");
        break;
    }
    case 4 : {
        System.Console.WriteLine("Будний день");
        break;
    }
    case 5 : {
        System.Console.WriteLine("Будний день");
        break;
    }
    case 6 : {
        System.Console.WriteLine("Выходной");
        break;
    }
    case 7 : {
        System.Console.WriteLine("Выходной");
        break;
    }
    default : {
        System.Console.WriteLine("Такого значения нет");
        break;
    }
}