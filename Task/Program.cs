
int FindArraySize(string[] array)
{
    int count = 0;

    foreach (string elem in array)
    {
        if (elem.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] MakeNewArray(int size, string[] array)
{
    string[] newArray = new string[size];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

void PrintArrays(string[] array, string[] array1)
{
    Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}].");
    Console.WriteLine($"Полученный массив: [{String.Join(", ", array1)}]");
    Console.WriteLine();
}

Console.Clear();

string[] array = { "Hello", "2", "world", ":-)" };
int size = FindArraySize(array);
string[] newArray = MakeNewArray(size, array);
PrintArrays(array, newArray);

string[] array2 = { "1234", "1567", "-2", "computer science" };
size = FindArraySize(array2);
string[] newArray2 = MakeNewArray(size, array2);
PrintArrays(array2, newArray2);

string[] array3 = { "Russia", "Denmark", "Kazan" };
size = FindArraySize(array3);
string[] newArray3 = MakeNewArray(size, array3);
PrintArrays(array3, newArray3);