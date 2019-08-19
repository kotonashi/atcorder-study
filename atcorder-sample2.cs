using System;
class Program
{
    static void Main(string[] args)
    {
        //スペースで区切られた整数の入力
        String[] lines=Console.ReadLine().Split(' ');
        int a=int.Parse(lines[0]);
        int b=int.Parse(lines[1]);

        //a*bが奇数か偶数か
        if((a*b)%2==0){
            Console.WriteLine("Even");
        }else{
            Console.WriteLine("Odd");
        }
    }
}


