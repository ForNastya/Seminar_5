// Поиск суммы элементов массива.
int[] array = {7, 10, 21, 6, 1, 11};
int sum = 0;
foreach (int element in array)
{
    sum += element;
}
Console.WriteLine(sum);