/*
Урок 1. Контрольная работа
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/



// /// <summary>
// /// Метод печатает элементы архива в обратном порядке.
// /// </summary>
// /// <param name="array"> архив </param>
// /// <param name="j"> индекс последнего элемента архива </param>
// void PrintReverseArray(int[] array, int j)
// {
//     //Базовый случай
//     if (j == 0)
//     {
//         Console.Write($"{array[j]} ]");
//         return;
//     }
//     //Рекурсивный случай
//     Console.Write($"{array[j]}, ");
//     PrintReverseArray(array, j - 1);
// }

string[] CreatArray(int size) //Метод заполнения массива пользователем.
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i + 1} element of the array: "); 
        array[i] = Console.ReadLine()!;
    }
    return array;
}

int LengthArray(string[] array) //Метод подсчета количества элементов массива длинна которых <= 3
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++; 
            //Console.WriteLine(array[i]);   
        }
    }
    return count;
}

string[] CreatNewArray(string[] array, int size, int count) //Метод создания нового массива из элементов массива длинна которых <= 3
{
    string[] arrayNew = new string[count];
    int cnt = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[cnt] = array[i];
            cnt++; 
              
        }
        
    }
    return arrayNew;
}

Console.Clear();
Console.Write($"Enter the size of the array, n = ");
int size = int.Parse(Console.ReadLine()!);
string[] matrix = CreatArray(size);
int count = LengthArray(matrix);
Console.WriteLine($"Massive:\t [ {string.Join(", ", matrix)} ]");
string[] matrixLength3 = CreatNewArray(matrix, size, count);
Console.WriteLine($"Massive:\t [ {string.Join(", ", matrixLength3)} ]");
//Console.WriteLine($"count = {LengthArray(matrix)}");
// Console.Write("Massive reverse: [ ");
// PrintReverseArray(matrix, size - 1);