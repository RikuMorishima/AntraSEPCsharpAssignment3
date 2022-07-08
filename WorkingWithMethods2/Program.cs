// See https://aka.ms/new-console-template for more information


class FibonacciSeq
{
    private static int[] list= {1,1};
    static int Fibonacci(int value)
    {
        if (value == 1 || value == 2)
            return 1;

        if (list == null || list.Length < value )
        {
            list = new int[value + 2];
            list[0] = 1;
            list[1] = 1;
        } else
        {
            return list[value - 1];
        }
            
        for (int i = 2; i < list.Length; i++)
        {
            list[i] = list[i - 2] + list[i - 1];
        }
        return list[value-1];
    }

    public static void Main(string[] args)
    {
        for (int i = 1; i <= 10; ++i)
            Console.WriteLine("{0}:{1} ",i,Fibonacci(i));
    }
}