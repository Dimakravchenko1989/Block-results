// Написать программ, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна трем символам. 
// Первоначальный массив задать с клавиатуры, либо задать на старте выполнения алгоритма.

string[] GenArray(string[] array) //Проверка исходного массива на 3х-значные символы
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

//Создание массива с тремя символами

    string[] newarray = new string[count]; 
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

// Печать массива
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

string[] array = { "hello", "2", "world", ":-)" };


Console.WriteLine("Задан массив: ");
PrintArray(array);
Console.WriteLine();

string[] newarray = GenArray(array);
Console.WriteLine("В этом массиве символов <= 3: ");
PrintArray(newarray);