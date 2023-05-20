// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


int length = GetLength();
System.Console.WriteLine("Введите элименты массива:");

string [] symbolArray = CreateArray(length);
System.Console.WriteLine("Задан массив: ");
PrintArray(symbolArray);

System.Console.WriteLine("Изменённый массив:");
PrintArray(ModifiedArray(symbolArray));


int GetLength()
{
    int number;
    System.Console.Write("Введите количество элементов в массиве: ");
    while (!int.TryParse(System.Console.ReadLine(), out number))
    {
        System.Console.WriteLine("Это не число!");
    }
    return number;
}


string[] CreateArray(int Length)
{
    string [] array = new string [Length];
    for (int i = 0; i < Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}


void PrintArray(string[] аrray)
{
    for (int i = 0; i < аrray.Length; i++)
    {
        Console.Write($"{аrray[i]} ");
    }
    Console.WriteLine();
}


string[] ModifiedArray(string[] array)
{
    string [] changeArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            changeArray[count] = array[i];
            count++;
        }
    }
    return changeArray;
}