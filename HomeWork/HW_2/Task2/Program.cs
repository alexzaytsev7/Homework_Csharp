//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int ostatok = number / 100 % 10;
double result = number;
int number4 = number;
int count = 0;
// подсчте кол-ва цифр в числе

    while (number4 != 0)
    {
        number4 /= 10;
        count++;
    }
// Делаем трехзначное число

double number2 = number / Math.Pow(10, count-3);

if (ostatok == 0)
    {
    Console.WriteLine("В числе нет третьей цифры");
    }
else
   {
     Console.WriteLine("треxзначное число: " +number2);
     result = number2 % 10;
    result = Math.Round(number2 % 10, MidpointRounding.ToZero);
     //result = Math.Round(Convert.ToInt32(number2) % 10, MidpointRounding.ToZero);
     Console.WriteLine("Третье число: " +result);
   }
   
 Console.WriteLine("Кол-во цифр " + count);