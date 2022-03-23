﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

using System;

const int size_N = 8;           // количество элементов в массиве
const int max_number = 100;     // максимальное генерируемое число

int [] my_array = new int[size_N];  // объявляем массив

var rnd = new Random();         // инициализируем генератор случайных чисел
for (int i=0; i<size_N; i++)    // обходим все элементы массива
{
    my_array[i]=rnd.Next(0,max_number); // и присваиваем им случайные занчения из промежутка 0..max_number-1
}

Console.Write("["); // красиво выводим первую скобку

for (int i=0; i<size_N-1; i++)  // обходим все элементы массива, кроме последнего
{
    Console.Write($"{my_array[i]},");   // выводим значения элементов массива и ставим запятую полсе каждого
}
Console.WriteLine($"{my_array[size_N-1]}]");  // выводим последний элемент, и ставим после не , а ]