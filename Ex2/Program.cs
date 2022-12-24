/*
Задача 66: 
Задайте значения M и N. 
Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string text)
{
    Console.WriteLine(text);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
    }
    return result;
}

int GetSumm(int m, int n)
{
    int s = 0;
    if (m < n)
    {
        s = m + GetSumm(m + 1, n);
    } 
    return s;
}

int m = GetNumber("Введите M: ");
int n = GetNumber("Введите N: ");
Console.WriteLine($"{GetSumm(m + 1, n)}");