using System.Diagnostics;

int n = 5;
var sw = new Stopwatch();

while (n <= 100)
{
    sw.Reset();
    sw.Start();
    var fibResRec = FibonacciRecursion(n);
    sw.Stop();
    Console.WriteLine("Рекурсивным методом для числа " + n + " результат составил: " + fibResRec + ". Затрачено " + sw.ElapsedMilliseconds + "ms");
    
    sw.Reset();
    sw.Start();
    var fibResCyc = FibonacciCycle(n);
    sw.Stop();
    Console.WriteLine("Итеративным методом для числа " + n + " результат составил: " + fibResCyc + ". Затрачено " + sw.ElapsedMilliseconds + "ms");
    
    n+=5;
}

int FibonacciRecursion(int n)
{
    if (n==0 || n==1)
    {
        return n;
    }
    return (FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2));
}

int FibonacciCycle(int n)
{
    int result = 0;
    int resultN_1 = 1;
    int resultN_2 = 0;
    for (int i = 0; i <= (n-2); i++)
    {
        result = resultN_1 + resultN_2;
        resultN_2 = resultN_1;
        resultN_1 = result;
    }
    return result;
}