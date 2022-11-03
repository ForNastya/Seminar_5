// Реализовать следующие функции:1.Функцию, которая вычисляет число a в степени n
void FillArray(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

double NumberAN(int A = 7, int N = 11)
{
    return Math.Pow(A,N);
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
}

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0");
FillArray(array, 5, 30);
NumberAN();
PrintArray(array);

