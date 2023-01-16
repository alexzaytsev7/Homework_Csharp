// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Находим макисмум из двух введенных чисел");
Console.WriteLine("Пожалуйста, введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int maxnumber = Math.Max(number1, number2);
Console.WriteLine("Максимальное число "+maxnumber);
