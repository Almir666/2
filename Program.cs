// Написать программу, которая из имеющегося массивастрок формирует массив строк, длина 
// которыъ меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.  

string[] MassivStrok = {"Hello", "cat", ":-)", "World"};

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            Console.Write($" {arr[i]} ");
        }
    }
}

Console.WriteLine();
Console.WriteLine("Сформирован массив из подходящих строк:");
PrintArray(MassivStrok);
Console.WriteLine();
Console.WriteLine();