// Задача:
// Написать программу, которая из меющегося массива строк формирует
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении использовать массивы.

using static System.Console;
Clear();

WriteLine("Введите массив строк через пробел: ");

string inParams = ReadLine()!;
string[] array = inParams.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine();
WriteLine("Новый массив с длиной строк не более 3 символов:");
PrintArray(SortArray(array));

string[] SortArray(string[] inArray)
{
    string[] resultArray = new string[inArray.Length];
    int i = 0;

    foreach (var charactersSet in inArray)
    {
        if (charactersSet.Length <= 3)
        {
            resultArray[i] = charactersSet;
            i++;
        }
    }
    return resultArray;
}

void PrintArray(string[] inArray)
{
    Write("[ ");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        if(inArray[i] != null) Write($"{inArray[i]} ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}
