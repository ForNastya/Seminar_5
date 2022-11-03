// Функцию, которая вычисляет сумму цифр произвольного целого числа n
double SumNum(int N)
{
    int sum = 0;
   while(N > 0)
   {
    int tail = N % 10;
    N = N / 10;
    sum = sum + tail;
   }
return sum;
}
