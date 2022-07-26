// Написать программу, которая из имеющегося массивастрок формирует массив строк, длина 
// которыъ меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.  


string[] StrLength3(string[] arrayOld)
{
    string[] arrayNew = new string[arrayOld.Length];
    for(int i = 0; i < arrayOld.Length; i++)
    {
        arrayNew[i] = arrayOld[i];
    }
    return arrayNew;
}

int letter = 3;
string[] data = new string[] {"Hello", "hi", ":)", "cat", "World"};
string[] result = new string[0];
for(int i = 0; i < data.Length; i++)
{
    int strLength = data[i].Length;
    if(strLength <= letter)
    {
        result = StrLength3(data);
    }
}

Console.WriteLine(String.Join(", ", result));