// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int n, int m, int sum)
{
    if (n <= m && m>=0)
    {
                sum = sum + n;
                n++;
                SumNumbers(n, m, sum);

    }
    else if (n>m)
    Console.WriteLine($"Сумма натуральных чисел в промежутке n и m = {sum}");
    return sum;
        
}

int GetNumber()
{
    Console.Write($"Введите значение чисел N и M: ");
    int.TryParse(Console.ReadLine(), out int result);
    return result;
}

int n = GetNumber();
int m = GetNumber();
int sum = 0;
SumNumbers(n, m, sum);
    