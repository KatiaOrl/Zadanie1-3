﻿using System;

namespace Zadanie1_3
{
    class Program
    {
        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка вставками
        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 0) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программирование в среде DOtNet");
            Console.WriteLine("Лкекция №1          Задание 1-3");
            Console.WriteLine("Сортировка вставками");
            Console.WriteLine("Выполнила: Орлова Е.В.  гр 7305");
            Console.WriteLine("Сортировка вставками");
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }

            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", InsertionSort(array)));

        }
    }
}