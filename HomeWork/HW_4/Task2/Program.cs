// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

double res = sumN(N);
Console.WriteLine($"Результат: {res}");


// if (!int.TryParse(Console.ReadLine(), out N) || N <= 0) {
//     Console.WriteLine("Введено не целое или отрицательное число");
//     return;
// }

double sumN(int N)
{  
    // if (N<0)
    // {
    //     Console.WriteLine("Введено отрицательное число");
    // }

    int res = 0;

while (N>0)
{
    int number2 = N % 10;
    res =res+number2;
    N=N/10;

}
return res;

}



