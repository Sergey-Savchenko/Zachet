# Решение

## Текст Задачи

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

["Hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

## Описание Решения.

Основу программы составляют три функции:

1. Функция ввода первоначального массива.
2. Функция вывода массива.

Первые две функции состоят из одного цикла for.

Первая функция считывает ввод с консоли и таким образом наполняет первоначальный массив.

Вторая функция выводит в консоль содержимое массива.

3. Функция наполнения результирующего массива.

Третья функция состоит из двух циклов for.

Первый цикл определяет длину результирующего массива.

Второй цикл наполняет результирующий массив строками, проходящими по заданной длине.