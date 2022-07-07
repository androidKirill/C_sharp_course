// 1. Напишите цикл, который принимает на вход два числа (A и B)
//    и возводит число A в натуральную степень B.


int PowNum(int a, int b)
{   
    int n_pow = a;
    
    for (int i = 2; i < b; i++)
    {
        n_pow *= a; 
    }  
    return n_pow;  
}

Console.WriteLine(PowNum(3, 5));
Console.WriteLine(PowNum(2, 4));