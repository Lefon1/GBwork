﻿// Задача: 
// Написать программу, которая из имеющегося массива строк формирует массив строк, меньше или равна 3 символам.
// Первоночальный массив вводится с клавиатуры или задается на старте.выполнения алгоритма.

// Метод для вывода одномерного массива строк в консоль
void Print1DArry(string[] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
Console.Write($"[{array[i]}]\t");
}
}

// Метод, который находит строки в массиве длиной не больше count
// И возвращает новый массив из этих строк
string[] GetNewArray(string[] arry, int count)
{
string[] result = new string[0];
for (int index = 0; index < arry.Length; index++)
{
if (arry[index].Length <= count)
{
result = result.Concat(new string[] { arry[index] }).ToArray();
}
}
return result;
}

// Запросить у пользователя ввод элементов массива через пробел
Console.WriteLine("Введите элементы массива через пробел:");
string input = Console.ReadLine();
string[] strarray = input.Split(' ');

// Получить новый массив из строк, длина которых не больше 3
string[] resultStrarry = GetNewArray(strarray, 3);

// Вывести исходный массив и новый массив в консоль
Console.WriteLine("Исходный массив:");
Print1DArry(strarray);
Console.WriteLine();
Console.WriteLine("Массив из строк длина которых не больше 3:");

if (resultStrarry.Length != 0)
{
Print1DArry(resultStrarry);
}
else
{
Console.WriteLine("Массив пустой!!!");
}