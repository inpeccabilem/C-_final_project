static void Foo(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        Foo(n - 1);
    }
}