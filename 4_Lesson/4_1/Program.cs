// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

// 1 вариант

int NumCount(int num)
{
    string result = num.ToString();
    return result.Length;
}

Console.WriteLine(NumCount(456));
Console.WriteLine(NumCount(78));
Console.WriteLine(NumCount(89126));
