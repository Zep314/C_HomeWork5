// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

using System;


const int size_N=20;  // Зададим количество элементов массива

int [] array = new int[size_N];  // объявляем массив


void init_array()  // Заполняем массив случайными элеменами
{
    Random rnd = new Random();
    for(int i=0; i<size_N; i++)
    {
        array[i]=rnd.Next(-10,11);
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


int summ_odd(int [] local_array)  // функция возвращает сумму элементов массива, стоящих на нечетных индексах
{
    int ret = 0;  // сюда будем записывать результат
    for(int i=1;i<local_array.Length;i+=2)  // задаем переменную i=1 и выполняем цикл с шагом 2
    {
        ret += local_array[i];
    }
    return ret;  // возвращаем результат
}

// Собственно, сама программа
init_array();
Console.WriteLine("Начальный массив:");
print_array(array);
Console.WriteLine($"Сумма элементов массива, находящихся на нечетных позициях: {summ_odd(array)}");
