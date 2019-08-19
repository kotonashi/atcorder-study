using System;
class Program
{
    static void Main(string[] args)
    {
        //文字列を格納する
        String s=Console.ReadLine();
        var count =0;

        //文字列の中に１が何個あるかを確認する
        foreach(char i in s){
            if(i=='1'){
                count++;
            }
        }
        Console.WriteLine(count);

    }
}


