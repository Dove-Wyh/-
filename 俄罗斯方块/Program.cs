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
            new CubeInfo();
            new _Transform();
            new Model();
            new Draw();
            Game game = new Game();
            Main p = new Main();
            p.Start();

            while (!Game.instance.GameIsOver)
            {
                //Game game = new Game();
                
                //while (!Game.instance.GameIsOver)
                //{
                //    game.RealGame();
                //}
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.DownArrow || consoleKeyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    if (p.isStart)
                    {
                        p.Exit();
                    }
                    else
                    {
                        p.Start();
                    }
                }
                if (consoleKeyInfo.Key == ConsoleKey.Enter)
                {
                    if (p.isStart)
                    {
                        // 游戏逻辑
                        Console.Clear();
                        
                        while (!Game.instance.GameIsOver)
                        {
                            game.RealGame();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (Game.instance.GameIsOver)
            {
                Console.WriteLine("Game Over");
                Console.ReadKey();
            }
        }
    }
}
