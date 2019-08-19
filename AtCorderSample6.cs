using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int AliceSum = 0, BobSum = 0;
        int i = 0;


        //カード枚数の取得
        int N= int.Parse(Console.ReadLine());

        //プレイヤーの持ち手
        int[] Alice = new int[N];
        int[] Bob = new int[N];

        //カードの出目の収納
        String[] lines = Console.ReadLine().Split(' ');
        int[] tempLines=lines.Select(int.Parse).ToArray();
        List<int> cardNumber = new List<int>();
        cardNumber.AddRange(tempLines);

        while (cardNumber.Count >= 1)
        {
            Alice[i] = cardNumber.Max();
            cardNumber.Remove(Alice[i]);
            Bob[i] = cardNumber.Max();
            cardNumber.Remove(Bob[i]);
            i++;
        }

        for(int j = 0; j < Alice.Length; j++)
        {
            AliceSum += Alice[j];
        }

        for(int k = 0; k < Bob.Length; k++)
        {
            BobSum += Bob[k];
        }

        //回答
        int answer = AliceSum - BobSum;
        Console.WriteLine(answer);
    }
}
