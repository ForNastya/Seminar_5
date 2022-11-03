// Подсчёт количества вхождений элемента в массив
int ElementArray(int[] array, int num = 7)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i]==num) n++;
    return n;
}