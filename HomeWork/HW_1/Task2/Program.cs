// Задача 2: Напишите программу, которая на вход принимает три числа и выдаёт, какое число большее, а какое меньшее.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Находим макисмум из трех введенных чисел");
Console.WriteLine("Пожалуйста, введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxnumber = 0;
for (int i = 1; i<3; i++)
{
    if (maxnumber < number1)
        maxnumber = number1;
    if (maxnumber < number2)
        maxnumber = number2;
    if (maxnumber < number3)
        maxnumber = number3;
}

Console.WriteLine("Максимальное число "+maxnumber);
