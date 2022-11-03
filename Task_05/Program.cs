// Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
int IndexArray(int[] array, int num = 7)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i]==num)
        return i;
    return -1;
}