// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber()
{
    Console.Write($"Введите значение чисел N и M: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}

static int AkkermanNumbers(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AkkermanNumbers(n - 1, 1);
    else
      return AkkermanNumbers(n - 1, AkkermanNumbers(n, m - 1));
}

int n = GetNumber();
int m = GetNumber();

AkkermanNumbers(n, m);
int AkkermanNumber = AkkermanNumbers(n, m); 
Console.WriteLine($"Результат вычисления функции Аккермана = {AkkermanNumber}");



