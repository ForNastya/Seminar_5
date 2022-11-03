// Проверка наличия элемента в массиве. Возвращает true, если элемент в массиве есть, false – нет.
bool PresenceArray(int[] array, int num = 7)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i]==num)
        return true;
    return false;
}