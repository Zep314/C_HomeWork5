// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве

using System;


const int size_N=20;  // Зададим количество элементов массива

int [] array = new int[size_N];  // объявляем массив


void init_array()  // Заполняем массив случайными элеменами
{
    Random rnd = new Random();
    for(int i=0; i<size_N; i++)
    {
        array[i]=rnd.Next(100,1000);
    }
}

void print_array(int [] local_array)  // Функция печати массива
{
    Console.Write("[");  // Выводим красивую скобку
    for(int i=0; i < local_array.Length-1; i++)  // Печатаем все элементы масиива, разделенные запятой, 
    {                                            // кроме последнего элемента
        Console.Write($"{local_array[i]}, ");
    }
    Console.WriteLine($"{local_array[local_array.Length-1]}]");  // Печатаем последний элемент массива со скобкой
}

int count_even(int [] local_array)  // функция подсчета четных элементов массива
{
    int ret = 0;  // сюда будем записывать результат
    for(int i=0;i<local_array.Length-1;i++)
    {
       if (local_array[i] % 2 == 0) {ret++;}
    }
    return ret;  // возвращаем результат
}

// Собственно, сама программа
init_array();
Console.WriteLine("Начальный массив:");
print_array(array);
Console.WriteLine($"Количество четных элементов в массиве: {count_even(array)}");
