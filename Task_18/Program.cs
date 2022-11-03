// Функцию, которая проверяет является ли заданное число n полиндромом
bool Palindrom(int N)
{
    string str = N.ToString();
    char [] ar = str.ToCharArray();
    int j = 0;
    int a = ar.Length/2;
    
for(int i=0; i<a; i++)
{
    int n = ar[i];
    int m =ar[ar.Length-1-i];
	if (m==n)j++;
}
if (j==a)
return true;
else
return false;
}