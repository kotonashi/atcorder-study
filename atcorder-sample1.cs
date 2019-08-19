using System;
class Program
{
    static void Main(string[] args)
    {
        //整数の入力
        int a = int.Parse(Console.ReadLine());

        //スペースで区切られた整数の入力
        String[] lines=Console.ReadLine().Split(' ');
        int b=int.Parse(lines[0]);
        int c=int.Parse(lines[1]);

        string s=Console.ReadLine();

        //回答
        Console.WriteLine((a+b+c) + " " + s );

    }
}