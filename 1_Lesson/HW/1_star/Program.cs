﻿// *. Напишите программу вычисления модуля числа.

int N = int.Parse(Console.ReadLine());

if (N < 0)
{
    N = -N;
}

Console.Write(N);