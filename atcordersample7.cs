using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;

        int j = 0;
        //鏡餅の個数
        int N = int.Parse(Console.ReadLine());
        int[] d = new int[N];
        //鏡餅の直径
        while (j<N)
        {
            d[j] = int.Parse(Console.ReadLine());
            j++;
        }
        Array.Sort(d);
        Array.Reverse(d);

        for(int i = 0; i < N; i++)
        {

                if (i == 0) count++;
                else if (i > 0 && d[i] == d[i - 1]) ;
                else count++;
        }

        //回答
        Console.WriteLine(count);
    }
}
