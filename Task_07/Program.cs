// Печать массива на экран
void FillArray(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
}

Console.WriteLine("Введите размер массива ");

int size = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int [size];
FillArray(array, 1, 33);
PrintArray(array);