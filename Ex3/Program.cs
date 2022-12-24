/*
Задача 68: 
Напишите программу вычисления функции 
Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int Akker(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akker(n - 1, 1);
    else
      return Akker(n - 1, Akker(n, m - 1));
}

int m = GetNumber("Введите M: ");
int n = GetNumber("Введите N: ");
Console.WriteLine($"{Akker(m, n)}");