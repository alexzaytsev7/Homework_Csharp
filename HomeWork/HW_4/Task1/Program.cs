// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");


if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0) {
    Console.WriteLine("Введено не целое или отрицательное число");
    //return;
}
int result = N;

Console.WriteLine("Введите степень числа: ");

if (!int.TryParse(Console.ReadLine(), out int b) || b <= 0) {
    Console.WriteLine("Введено не целое или отрицательное число");
    //return;
}

double stepen(int N, int b)
{
    for(int i=1; i<b; i++){
        result = result * N;
    }

return result;
}

double res = stepen(N, b);
Console.WriteLine($"Результат: {res}");
