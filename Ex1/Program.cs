/*
Задача 64: 
Задайте значение N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string text)
{
    Console.WriteLine("Введите число больше 1");
    int result = 0;
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
    }
    return result;
}

void Numbers(int n)
{
    Console.Write($"{n}, ");
    if (n > 1)
    {
        Numbers(n - 1);        
    }
}

int n = GetNumber("Введите N");
Numbers(n);