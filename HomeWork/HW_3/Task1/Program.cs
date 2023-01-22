// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно 
// палиндромом (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] 
// делать НЕЛЬЗЯ. Используем операторы % и /).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

//  int Palindromnumber(int number) {

//    if()
// }
// int a1, a2, a3, a4, a5 = 0;
// int b1, b2, b3, b4, b5 = 0;


int c = 4; //коли-во цифр в числе -1
int i = 0;

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

double result = Convert.ToDouble(number);
double b5 = result;
double b6 = 0;
double b7 = result;
   
if (number < 9999 || number > 99999){
        Console.WriteLine("Введено не пятизначное число");
}

while (c>=0){
   int mnogitel = Convert.ToInt32(Math.Pow(10, i));

    int delitel = Convert.ToInt32(Math.Pow(10, c));
    
    b5 = Math.Round(b7 / mnogitel  % 10, MidpointRounding.ToZero);
    b6 = b6 + b5 * delitel;

    i++;
    c=c-1;
}

Console.WriteLine("Введенное число в обратном порядке: "+b6);

// while (c>=0){
//    int mnogitel = Convert.ToInt32(Math.Pow(10, i));

//     int delitel = Convert.ToInt32(Math.Pow(10, c));
    
//     b5 = Math.Round(b7 / mnogitel  % 10, MidpointRounding.ToZero);
//     b6 = b6 + b5 * delitel;

//     i++;
//     c=c-1;
// }
double a1, a2, a4, a5;

a1 = Math.Round(b7 / 1  % 10, MidpointRounding.ToZero);
a2 = Math.Round(b7 / 10  % 10, MidpointRounding.ToZero);
a4 = Math.Round(b7 / 1000  % 10, MidpointRounding.ToZero);
a5 = Math.Round(b7 / 10000  % 10, MidpointRounding.ToZero);

if (a1 == a5 && a2 == a4){
    Console.WriteLine("Введенное число является палиндром");
}
else
    Console.WriteLine("Введенное число НЕ является палиндром");

