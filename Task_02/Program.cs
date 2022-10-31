// Поиск максимального
int[] array = {7, 10, 21, 6, 1, 11};
int max = int.MaxValue;
max = array[0];
for(int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
}
Console.WriteLine(max);
