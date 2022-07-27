// Написать программу, которая из имеющегося массивастрок формирует массив строк, длина 
// которыъ меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.  


string[] arrayOld = new string[] { "fwer", "cat", "gerg", "fsfg", "ff" };

int ArrayFindWords3(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] ArrayComplete(string[] arr, int count)
{
    int j = 0;
    string[] arrayNew = new string[count];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrayNew[j] = arr[i];
            j++;
        }
    }
    return arrayNew;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

PrintArray(ArrayComplete(arrayOld, ArrayFindWords3(arrayOld)));
