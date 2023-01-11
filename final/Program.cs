string[] array_first = new string[8] {"321", "89", "hello", "world", "computer", "167", "1875", "13"};
string[] array_second = new string[array_first.Length];
void Processing(string[] array1, string[] array_second)
{
    int k = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array_second[k] = array1[i];
        k++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Processing(array_first, array_second);
PrintArray(array_second);