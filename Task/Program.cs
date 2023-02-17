// Задача:
// Написать программу, которая из меющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении использовать массивы.

using static System.Console;
using Library;
Clear();

WriteLine("Введите массив строк через пробел: ");

string inParams = ReadLine()!;
string[] array = inParams.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine();
WriteLine("Новый массив с длиной строк не более 3 символов:");
Methods.PrintArray(Methods.SortArray(array));
