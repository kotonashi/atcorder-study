using System;
class Program
{
    static void Main(string[] args)
    {
        int count=0;
        int min=100000;
        int[] tempLines=new int[n];
        //整数の入力
        int n = int.Parse(Console.ReadLine());


        //スペースで区切られた整数の入力
        String[] lines=Console.ReadLine().Split(' ');

        //文字列→数値化
        for(int i=0;i<lines.Length;i++){
            int times=0;
            tempLines[i]=int.Parse(lines[i]);
            while(tempLines[i]%2==0){
                tempLines[i] /=2;
                times++;
            }
            min=Math.Min(min,times);
        }
        //回答
        count=min;
        Console.WriteLine(count);
    }
}