// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]



//Console.WriteLine("Введите через запятую числа для массива");
// int number = Convert.ToInt32(Console.ReadLine());



                 
            // Console.WriteLine("Введите размерность массива:");
            // int i, n = Convert.ToInt32(Console.ReadLine());
            // int[] mas = new int[n];
          
            // Console.WriteLine("Введите массив:");
            // string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            // for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
            //     mas[i] = Convert.ToInt32(str[i]);
            // Console.WriteLine("Введенный массив:");
            // for (i = 0; i < n; ++i)
            //     Console.Write("{0} ", mas[i]);
            // Console.ReadLine();
        
                
        //}

// int[] EnterArray(int N)
//     {
//         int[] array 
//     }


            Console.WriteLine("Введите размерность массива:");
            int i, n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Console.WriteLine("Введите массив:");
            string[] str = Console.ReadLine().Split(new char[] { ' ',',', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);


void PrintArray(int [] mas)
{
            for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
                mas[i] = Convert.ToInt32(str[i]);
            Console.WriteLine("Введенный массив:");
            for (i = 0; i < n; ++i)
                Console.Write("{0} ", mas[i]);
            Console.ReadLine();

}

PrintArray(mas);