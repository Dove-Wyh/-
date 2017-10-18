using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
    class Main
    {
        public bool isStart = true;

        //指针指向开始游戏的界面
        public void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
            }
            for (int i = 0; i < 54; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("->开始游戏");
            for (int i = 0; i < 56; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("退出游戏");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
            }
            isStart = true;
        }
        //指针指向结束游戏的界面
        public void Exit()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
            }
            for (int i = 0; i < 54; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("  开始游戏");
            for (int i = 0; i < 54; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("->退出游戏");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
            }
            isStart = false;
        }
    }
}
