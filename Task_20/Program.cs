// Функцию, определяющую является ли число простым, то есть возвращающую true, если число простое, иначе - false
bool ProstNum(int N)
{
    int m = 0;
    for(int i = 2; i < 10; i++)
        if( N != i)
        {
            if(N % i == 0) m++;
        }
    if(m == 0)
    return true;
    else
    return false;
}