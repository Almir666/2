// Написать программу, которая из имеющегося массивастрок формирует массив строк, длина 
// которыъ меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.  

Console.WriteLine("Привет дружок! Введи колличество элементов массива :* ");
int CollichestvoStrok = int.Parse(Console.ReadLine());
string[] MassivStrok = new string[CollichestvoStrok];
void FillArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введи " + (count + 1) + " элемент из символов" + ":");
        arr[i] = Console.ReadLine();
        count++;
    }
}
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

FillArray(MassivStrok);
Console.WriteLine();
Console.WriteLine("Сформирован массив из подходящих строк:");
PrintArray(MassivStrok);
Console.WriteLine();
Console.WriteLine();