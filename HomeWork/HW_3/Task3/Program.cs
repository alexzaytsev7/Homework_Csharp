// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number, x;
Console.WriteLine("Введите число от 1 до N");

if(!int.TryParse(Console.ReadLine(), out number)){
        Console.WriteLine("Введено не целое число");
        return;
}

if(number < 0){
    Console.WriteLine("Введено отрицательное число");
    return;
}


double Cub(double x)
{
    return (x * x * x);
}

Console.WriteLine($"Куб введенного числа: ");
int i=1;
while(i<=number)
{
    Console.Write(Cub(i));
    if (i<number)
    Console.Write(", ");
    i++;
}

 