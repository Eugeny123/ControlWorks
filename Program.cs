
string[] arrayString = { "Hello", "2", "World", ":-" };
string[] arrayDouble = new string[arrayString.Length];

void FillingArrayDouble(string[] arrayString, string[] arrayDouble)
{
    int count = 0;
    for (int i = 0; i < arrayString.Length; i++)
    {
        if (arrayString[i].Length <= 3)
        {
            arrayDouble[count] = arrayString[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ,");
    }
    Console.WriteLine();
}

FillingArrayDouble(arrayString, arrayDouble);
PrintArray(arrayDouble);





