// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");
//Console.WriteLine(is123Array(new int[] {7,2,7,2,7,2,7,2,3,7,7}));

Console.WriteLine(isTwinPaired(new int[] {}));

int isTwinPaired(int[] a)
{

    int lastEven = 0;
    int lastOdd = 0;

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0 && a[i] >= lastEven)
            lastEven = a[i];
        else if (a[i] % 2 != 0 && a[i] >= lastOdd)
            lastOdd = a[i];
        else return 0;
    }

    return 1;
}

int isPrimeHappy(int n){
    if(n == 2) return 0;

    List<int> primes = new List<int>();

    for (int i = 2; i < n; i++)
    {
        if (IsPrime(i))
        {
            primes.Add(i);
        }
    }

    return (primes.Sum() % n == 0) ? 1 : 0;
}

int is123Array(int[] a)
{
    int found = 0;
    int notFound = 0;

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 == 0)
            found++;

        if (a[i] % 3 == 0)
            found++;

        if (a[i] % 5 == 0)
            found++;

        if (a[i] % 2 != 0 && a[i] % 3 != 0 && a[i] % 5 != 0)
            notFound++;
    }

    return (found + notFound) == a.Length ? 1 : 0;
}

//static List<int> GetPrimes(int limit)
//{
//    List<int> primes = new List<int>();

//    for (int number = 2; number < limit; number++)
//    {
//        if (IsPrime(number))
//        {
//            primes.Add(number);
//        }
//    }

//    return primes;
//}

static bool IsPrime(int number)
{
    if (number < 2)
    {
        return false;
    }

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return true;
}