// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

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


int get_minmax_index(int [] local_array, int is_max)    // Находим максимальный или минимальный индекс элемента массива
{                                                       // is_max == 1 - максимальный
    int ret = 0;                                        // is_max == 0 - минимальный
    for (int i=1;i<local_array.Length;i++)  // проверяем все элементы массива
    {
        if (   // большое логическое выражение - все вычисляем за один раз
            ( (is_max==1)&&(local_array[i]>local_array[ret]) ) 
            ||
            ( (is_max==0)&&(local_array[i]<local_array[ret]) ) 
           )
            ret = i;
    }
    return ret;
}

// Собственно, сама программа
init_array();
Console.WriteLine("Начальный массив:");
print_array(array);
Console.WriteLine($"Максимальный элемент массива: array[{get_minmax_index(array,1)}]={array[get_minmax_index(array,1)]}");
Console.WriteLine($"Минимальный  элемент массива: array[{get_minmax_index(array,0)}]={array[get_minmax_index(array,0)]}");
Console.WriteLine($"Разность array[{get_minmax_index(array,1)}] - array[{get_minmax_index(array,0)}]: {array[get_minmax_index(array,1)]} - {array[get_minmax_index(array,0)]} = {array[get_minmax_index(array,1)]-array[get_minmax_index(array,0)]}");
