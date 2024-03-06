//Task testwork

/// <summary>
/// Метод заполнения массива пользователем.
/// </summary>
/// <param name="size"> размер создаваемого массива строк, задается пользователем </param>
/// <returns> созданный массив </returns>
string[] CreatArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i + 1} element of the array: "); 
        array[i] = Console.ReadLine()!;
    }
    return array;
}

/// <summary>
/// Метод подсчета количества элементов массива строк, длинна которых <= 3.
/// </summary>
/// <param name="array"> массив строк введенный пользователем </param>
/// <returns> количество элеменов массива строк, длинна которых <= 3 </returns>
int CountElementArray(string[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++; 
        }
    }
    return count;
}

/// <summary>
/// Метод создания нового массива из элементов массива длинна которых <= 3
/// </summary>
/// <param name="array"> массив строк введенный пользователем </param>
/// <param name="sizeNewArray"> размер нового массива состоящего из элеменов длинна которых <= 3 </param>
/// <returns> массив строк состоящий из элеменов, длинна которых <= 3 </returns>
string[] CreatNewArray(string[] array, int sizeNewArray)
{
    string[] newArray = new string[sizeNewArray];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++; 
              
        }
        
    }
    return newArray;
}

Console.Clear();
Console.Write($"Enter the size of the array, n = ");
int size = int.Parse(Console.ReadLine()!);
string[] matrix = CreatArray(size);
int sizeNewArray = CountElementArray(matrix);
string[] matrixLength3 = CreatNewArray(matrix, sizeNewArray);
Console.WriteLine($"The original massive:\t [ {string.Join(", ", matrix)} ]");
Console.WriteLine($"New massive:\t [ {string.Join(", ", matrixLength3)} ]");
