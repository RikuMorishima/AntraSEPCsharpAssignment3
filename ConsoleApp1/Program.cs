class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(10);
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    private static int[] GenerateNumbers(int length)
    {
        int[] output = new int[length]; 
        for(int i = length; --i >=0;)
        {
            output[i] = i;
        }
        return output;
    }

    private static void Reverse(int[] ints)
    {
        int front = 0;
        int back = ints.Length - 1;
        while (front < back)
        {
            int temp = ints[front];
            ints[front++] = ints[back];
            ints[back--] = temp;
        }
    }

    private static void PrintNumbers(int[] ints)
    {
        foreach(int i in ints)
            Console.Write("{0} ", i.ToString());
    }
}