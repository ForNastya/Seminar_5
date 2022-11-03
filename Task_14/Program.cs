// Проверка является ли массив отсортированным по возрастанию. Если массив отсортирован, то возвращать true, иначе - false.
int[] array = {11, 5, 9, 1, 33};

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length - 1; i++)
    {
        int  minPosition = i;
        
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) n = n + 1;
        }
    }
if(n == 0)
{
    Console.Write(true);
}
else
{
    Console.Write(false);
}
}
PrintArray(array);
SelectionSort(array);
