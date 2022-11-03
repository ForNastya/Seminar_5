// Подсчёт количества чётных элементов в массив
int EvenArray(int[] array)
{
    int n = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) n++;
    return n;
}
