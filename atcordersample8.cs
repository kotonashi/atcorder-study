using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
        int z = 0;
        int tx = 0;
        int ty = 0;
        int tz = 0;

        String[] lines = Console.ReadLine().Split(' ');

        //お札の枚数
        int N = int.Parse(lines[0]);
        //合計金額
        int Y = int.Parse(lines[1]);

        for (x = 0; x <= N; x++)
        {
            for (y = 0; y <= (N - x); y++)
            {
                z = N - x - y;

                    if ((10000 * x + 5000 * y + 1000 * z) == Y)
                    {
                        tx = x;
                        ty = y;
                        tz = z;
                        goto ANSWER;

                    }
                    else
                    {
                        tx = -1;
                        ty = -1;
                        tz = -1;
                    }

            }
        }
        x = tx;
        y = ty;
        z = tz;

        //回答
        ANSWER:;
        Console.WriteLine("{0} {1} {2}", x, y, z);
    }
}