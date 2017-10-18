using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
    class Program
    {
        static void Main(string[] args)
        {
            Main p = new Main();
            p.Start();

            while (true)
            {
                Game game = new Game();
                while (true)
                {
                    game.RealGame();
                }
                //ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                //if (consoleKeyInfo.Key == ConsoleKey.DownArrow || consoleKeyInfo.Key == ConsoleKey.UpArrow)
                //{
                //    Console.Clear();
                //    if (p.isStart)
                //    {
                //        p.Exit();
                //    }
                //    else
                //    {
                //        p.Start();
                //    }
                //}
                //if (consoleKeyInfo.Key == ConsoleKey.Enter)
                //{
                //    if (p.isStart)
                //    {
                //        // 游戏逻辑
                //        Console.Clear();
                //        Game game = new Game();
                //        while (true)
                //        {
                //            game.RealGame();
                //        }
                //    }
                //    else
                //    {
                //        break;
                //    }
                //}
            }
            //Console.ReadKey();
        }
    }
}
