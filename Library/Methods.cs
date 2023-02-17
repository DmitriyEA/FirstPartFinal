namespace Library;
using static System.Console;
public class Methods
{
    public static void PrintArray(string[] inArray)
    {
        Write("[ ");
        for (int i = 0; i < inArray.Length - 1; i++)
        {
            if (inArray[i] != null) Write($"{inArray[i]} ");
        }
        Write($"{inArray[inArray.Length - 1]}]");
    }

    public static string[] SortArray(string[] inArray)
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
}
