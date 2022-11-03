// Поиск произведения элементов массива
int MultArray(int[] array)
{
    int mult = 1;
    for(int i = 0; i < array.Length; i++)
    {
        mult = mult * array[i];
    }
    return mult;
}