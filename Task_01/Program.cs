// Поиск минимума
int[] array = {7, 10, 21, 6, 1, 11};
int min = int.MinValue;
min = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
}
Console.WriteLine(min);