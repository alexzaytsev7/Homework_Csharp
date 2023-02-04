// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void SumNaNechetPoz(int [] mas)
{
    int result = 0;   
    for(i=0; i < n ; i+=2){
    result +=mas[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");
}

PrintArray(mas);
//Проверка на указанное кол-во элемнтов массива с реально введенным
if (str.Length != n)
    Console.WriteLine("Указанное кол-во элемнтов массива не совпадает с реально введенным!");
else
SumNaNechetPoz(mas);
