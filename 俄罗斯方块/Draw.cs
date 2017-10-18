using System;

namespace 俄罗斯方块
{
    public class Draw
    {
        static Random r = new Random((int) DateTime.Now.Ticks);
        static int[,] title = new int[4,4];
        //输出第一行或者最后一行
        void Print1()
        {
            //for (int i = 0; i < 46; i++)
            //{
            //    Console.Write(" ");
            //}
            for (int i = 0; i < 12; i++)
            {
                Console.Write('■');
            }
            Console.WriteLine("");
        }

        //输出Rect中间行
        void Print2(int[,] table)
        {
            for (int j = 19; j >= 0; j--)
            {
                //for (int i = 0; i < 46; i++)
                //{
                //    Console.Write(" ");
                //}
                Console.Write('■');

                for (int i = 0; i < 10; i++)
                {
                    if (table[j, i] != 0)
                    {
                        Console.Write("■");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine('■');
            }
        }

        //预览下一个方块
        public static void PrintTitle()
        {
            int index = 0;
            //随机产出下一个方块
            if (!Game.instance.canDown)
            {
                index = r.Next(0, 20);
            }
            switch (index)
            {
                case 0:
                    DrawTitle(CubeInfo.cube11.cube);
                    break;
                case 1:
                    DrawTitle(CubeInfo.cube12.cube);
                    break;
            }
            Console.WriteLine("");
        }

        //画矩形
        public static void PrintRect()
        {
            Print1();
            Print2(table);
            Print1();
        }

        //画标题
        static void DrawTitle(int[,] title)
        {
            
        }
    }
}