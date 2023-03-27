// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив строк, меньше или равна 3 символам.
// Первоночальный массив вводится с клавиатуры или задается на старте.выполнения алгоритма.

// int ReadData(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine() ?? "0");
// }
// void Print1DArry(string[] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write($"[{array[i]}]\t");
//     }

// }

// string[] FilterArray(string[] inputArr)
//     {
//         int count = 0;
//         for (int i = 0; i < inputArr.Length; i++)
//         {
//             if (inputArr[i].Length <= 3)
//             {
//                 count++;
//             }
//         }
//         string[] outArr = new string[count];
//         int j = 0;
//         for (int i = 0; i < inputArr.Length; i++)
//         {
//             if (inputArr[i].Length <= 3)
//             {
//                 outArr[j] = inputArr[i];
//                 j++;
//             }
//         }
//         return outArr;
//     }


using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод количества элементов массива
        Console.Write("Введите количество элементов массива: ");
        int n = int.Parse(Console.ReadLine());

        // Создание исходного массива строк
        string[] inputArray = new string[n];

        // Ввод элементов массива с клавиатуры
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            inputArray[i] = Console.ReadLine();
        }

        // Создание нового массива строк
        string[] outputArray = new string[inputArray.Length];
        int count = 0;

        // Проход по каждой строке исходного массива
        for (int i = 0; i < inputArray.Length; i++)
        {
            // Проверка длины строки
            if (inputArray[i].Length <= 3)
            {
                // Добавление строки в новый массив
                outputArray[count] = inputArray[i];
                count++;
            }
        }

        // Вывод нового массива строк на экран
        Console.WriteLine("Массив строк, меньше или равных 3 символам:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(outputArray[i]);
        }

        Console.ReadLine();
    }
}