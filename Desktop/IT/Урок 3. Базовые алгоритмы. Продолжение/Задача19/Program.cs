// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// string[] str = new string[5];
// System.Console.WriteLine("Пятизначное число");
// string? number = Console.ReadLine();

// if (str!.Length == 5)
// {
//     if (str[0] == str[4] && str[1] == str[3])
//     {
//         System.Console.WriteLine("да");
//     }
//     else
//     {
//         System.Console.WriteLine("нет");
//     } 
// }
// else
// {
//     System.Console.WriteLine("Неверное число");
// }

        Console.WriteLine("Введите число: ");
        string? number = Console.ReadLine();
        int str = number!.Length;

        if (str == 5)
        {
            if (number[0] == number[4] && number[1] == number[3])
            {
                Console.WriteLine($"{number} - Палиндром");
            }
            else
            {
                Console.WriteLine($"{number} - НЕ палиндром");
            }
        }
        else
        {
            Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
        }
  



    




 ;

