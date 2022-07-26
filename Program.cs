// Написать программу, которая из имеющегося массивастрок формирует массив строк, длина 
// которыъ меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.  


string[] StrLength3(string[] arrayOld, string value)
{
    string[] arrayNew = new string[arrayOld.Length + 1];
    for (int i = 0; i < arrayOld.Length; i++)
    {
        arrayNew[i] = arrayOld[i];
    }
    arrayNew[arrayNew.Length - 1] = value;
    return arrayNew;
}

string[] array = new string[] { "Hello", "hi", ":)", "cat", "World" };
string[] result = new string[0];
for (int i = 0; i < array.Length; i++)
{
    int strLength = array[i].Length;
    if (strLength <= 3)
    {
        result = StrLength3(result, array[i]);
    }
}

Console.WriteLine(String.Join(", ", result));