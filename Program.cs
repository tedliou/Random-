using System;

namespace Random_Value
{
    class Program
    {
        /* Random 類別 亂數不重複 練習程式
         * 
         * Author: Yu-Pai Liu 偵錯桐人-電腦、遊戲、隨筆 
         * 
         * Url: https://tedliou.com
         * 
         * */
        static void Main(string[] args)
        {
            int max, min, n;

            Console.Write(">> 最大值： ");
            max = int.Parse(Console.ReadLine());

            Console.Write(">> 最小值： ");
            min = int.Parse(Console.ReadLine());

            Console.Write(">> 個數： ");
            n = int.Parse(Console.ReadLine());

            //  分隔線
            Console.WriteLine("////////////////////////////////////////////////");

            //  實體化Random類別
            Random rnd = new Random();

            //  宣告用來儲存亂數的陣列
            int[] ValueString = new int[n];

            //  亂數產生
            for (int i = 0; i < n; i++)
            {
                ValueString[i] = rnd.Next(min, max+1);

                //  檢查是否存在重複
                while (Array.IndexOf(ValueString, ValueString[i], 0, i) > -1)
                {
                    ValueString[i] = rnd.Next(min, max + 1);
                }

                //  排版
                Console.Write("\t" + ValueString[i]);
                if ((i + 1) % 5 == 0)
                {
                    Console.Write("\n");
                }
            }

            //  分隔線
            Console.WriteLine("////////////////////////////////////////////////");

            //  結束程式
            Console.WriteLine("<< 按任意鍵關閉視窗 >>");
            Console.ReadKey();
        }
    }
}