// Функция, которая вычисляет факториал числа n
double Factorial(int N)
{
    double Fact = 1; 
    if(N==0 || N==1)
    return 1;
    else
    for(int i = 1; i <= N; i++) 
    Fact = Fact * i;
return Fact;
}
