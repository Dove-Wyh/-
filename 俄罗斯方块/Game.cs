using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
    class Game
    {
        public static Game instance;
        Random r;
        public bool GameIsOver = false;
        bool canDown = true;
        bool first = true;
        int title;
        int cube;
        
        public int[,] table;

        public void RealGame()
        {
            Console.Clear();

            if (!canDown)
            {
                Model.instance.Change();
                cube = title;
                title = r.Next(0, 2);
            }
            if (!canDown || first)
            {
                Model.instance.CreateCube(cube);
                canDown = true;
                first = false;
            }
            //判断上一个方块是否落地
            while (canDown && !GameIsOver)
            {
                Console.Clear();
                _Down.Down();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (_Left.CanLeftMove())
                        {
                            _Left.LeftMove();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (_Right.CanRightMove())
                        {
                            _Right.RightMove();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (_Transform.CanTransform())
                        {
                            _Transform.Transform();
                        }
                        break;
                }
                Draw.instance.PrintTitle(title);
                Draw.instance.PrintRect();
                
                Thread.Sleep(1000);              //下降放在延时之前是为了让方块到达最后一行时候还能移动一下
                
                canDown = _Down.CanDown();
            }
        }
        
        

        public Game()
        {
            instance = this;
            r = new Random((int)DateTime.Now.Ticks);
            title = r.Next(0, 2);
            cube = r.Next(0, 2);
            table = new int[20, 10];
        }
    }
}
