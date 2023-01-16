//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число для вывода всех предшествующих четных чисел");
int number = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<number+1; i++)
{
    int result = i % 2;

    if (result == 0)

    Console.Write(i+"; ");
 
    
}


