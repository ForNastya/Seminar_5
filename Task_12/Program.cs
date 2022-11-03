// Подсчёт количества положительных элементов в массиве
int PositiveArray(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= 0) n++;
    return n;
}
