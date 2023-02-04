// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите размерность массива:");
            int i, n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Console.WriteLine("Введите массив:");
            string[] str = Console.ReadLine().Split(new char[] { ' ',',', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

void PrintArray(int [] mas)
{
            for (i = 0; i < (n < str.Length ? n : str.Length); ++i){
                mas[i] = Convert.ToInt32(str[i]);
            }
                  

}


void CountPolozitelnyh(int [] mas)
{
    int result = 0;   
    for(i=0; i < n ; i++){
        if(mas[i] > 0){
        result++;    
        }
    
    }
    Console.WriteLine($"Кол-во чисел в масиве больше 0: {result}");
}

//Проверка на указанное кол-во элемнтов массива с реально введенным

PrintArray(mas);
if (str.Length != n)
{
    Console.WriteLine("Указанное кол-во элемнтов массива не совпадает с реально введенным!");
return;
}
else
CountPolozitelnyh(mas);
