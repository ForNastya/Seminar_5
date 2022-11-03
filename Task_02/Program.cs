// Поиск максимального
int MaxArray(int[] array)
{
    int max = array[0];
    for(int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
}
return max;
}
