//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру дня недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());

if (number>0 && number<6)
{ 
    Console.WriteLine("Это рабочий день");
    
}
else if (number==6 | number==7)
{ 
    Console.WriteLine("Это выходной день");

}

else
 Console.WriteLine("Неверный ввод");


