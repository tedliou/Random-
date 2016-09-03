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
            /*  取得設定參數
             * 
             *  Max = 最大值
             *  Min = 最小值
             *  A = 個數
             * 
             * */
            string max, min, a;

            Console.Write(">> 最大值： ");
            max = Console.ReadLine();

            Console.Write(">> 最小值： ");
            min = Console.ReadLine();

            Console.Write(">> 個數： ");
            a = Console.ReadLine();

            //  分隔線
            Console.WriteLine("////////////////////////////////////////////////");

            //  實體化Random類別
            Random rnd = new Random();

            //  將取到的字串轉為數值格式
            int small, large, number;
            number = int.Parse(a);
            small = int.Parse(min);
            large = int.Parse(max) + 1;

            //  宣告用來儲存亂數的陣列
            int[] ValueString = new int[number];

            ///////////////////////////////////////
            //             
            //  亂數產生
            //      
            //////////////////////////////////////
            for (int i = 0; i < number; i++)
            {
                ValueString[i] = rnd.Next(small, large);

                //  檢查是否存在重複
                while (Array.IndexOf(ValueString, ValueString[i], 0, i) > -1)
                {
                    ValueString[i] = rnd.Next(small, large);
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