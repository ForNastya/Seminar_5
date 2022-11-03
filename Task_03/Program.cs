// Поиск суммы элементов массива.
int SumArray(int[] array)
{
    int sum = 0;
    foreach (int element in array)
        sum += element;
    return sum;
}