// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string [] CreateArray(int numb)
{
    string [] array = new string [numb];
    for(int i=0; i<numb; i++)
    {
        Console.Write($"Введите строку {i+1}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string [] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        if (i<array.GetLength(0)-1)
        {
        Console.Write($"{array[i]}, ");}
        else
        {
        Console.Write($"{array[i]}");}
    }
    Console.WriteLine();
}

string [] CheckArray(string [] array)
{
    int count = 0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        string x = array[i];
        if (x.Length < 4)
        {
            count++;
        } 
    }
    if (count<1)
    {
        Console.WriteLine("Удовлетворящих условию строк нет.");
    }
    string [] newarray = new string [count];
    int j = 0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        string x = array[i];
        if (x.Length < 4)
        {
            newarray [j] = array [i];
            j++;
        } 
    }
    return newarray;
}

System.Console.Write("Введите размер массива: ");
int razmer = Convert.ToInt32(Console.ReadLine());
string [] massiv = CreateArray(razmer);
// ShowArray(massiv);
string [] result = CheckArray(massiv);
Console.Write("Итоговый массив: ");
ShowArray(result);