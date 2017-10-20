using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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
        Cube title;
        Cube cube;
        int[] a;
        
        public int[,] table;

        public void RealGame()
        {
            Console.Clear();

            if (!canDown)
            {
                Model.instance.Change();
                _Eliminate.CanEliminate(out a);
                _Eliminate.Eliminate(a);
                cube = title;
                Choose();
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
                _Down.Down();

                Console.Clear();
                Draw.instance.PrintTitle(title);
                Draw.instance.PrintRect();
                A:
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                    switch (consoleKeyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (_Left.CanLeftMove())
                            {
                                _Left.LeftMove();
                                Console.Clear();
                                Draw.instance.PrintTitle(title);
                                Draw.instance.PrintRect();
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (_Right.CanRightMove())
                            {
                                _Right.RightMove();
                                Console.Clear();
                                Draw.instance.PrintTitle(title);
                                Draw.instance.PrintRect();
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (_Transform.instance.CanTransform(cube))
                            {
                                _Transform.instance.Transform();
                                cube = cube.next;
                                Console.Clear();
                                Draw.instance.PrintTitle(title);
                                Draw.instance.PrintRect();
                            }
                            break;
                    }
                    goto A;
                }
                
                
                Thread.Sleep(250);
                canDown = _Down.CanDown();
                _Eliminate.CanEliminate(out a);
                _Eliminate.Eliminate(a);
            }
        }

        public void Choose()
        {
            switch (r.Next(0, 19))
            {
                case 0:
                    title = CubeInfo.instance.cube11;
                    break;
                case 1:
                    title = CubeInfo.instance.cube12;
                    break;
                case 2:
                    title = CubeInfo.instance.cube21;
                    break;
                case 3:
                    title = CubeInfo.instance.cube31;
                    break;
                case 4:
                    title = CubeInfo.instance.cube32;
                    break;
                case 5:
                    title = CubeInfo.instance.cube33;
                    break;
                case 6:
                    title = CubeInfo.instance.cube34;
                    break;
                case 7:
                    title = CubeInfo.instance.cube41;
                    break;
                case 8:
                    title = CubeInfo.instance.cube42;
                    break;
                case 9:
                    title = CubeInfo.instance.cube43;
                    break;
                case 10:
                    title = CubeInfo.instance.cube44;
                    break;
                case 11:
                    title = CubeInfo.instance.cube51;
                    break;
                case 12:
                    title = CubeInfo.instance.cube52;
                    break;
                case 13:
                    title = CubeInfo.instance.cube61;
                    break;
                case 14:
                    title = CubeInfo.instance.cube62;
                    break;
                case 15:
                    title = CubeInfo.instance.cube71;
                    break;
                case 16:
                    title = CubeInfo.instance.cube72;
                    break;
                case 17:
                    title = CubeInfo.instance.cube73;
                    break;
                case 18:
                    title = CubeInfo.instance.cube74;
                    break;
            }
        }

        public Game()
        {
            instance = this;
            r = new Random((int)DateTime.Now.Ticks);
            title = CubeInfo.instance.cube11;
            cube = CubeInfo.instance.cube12;
            table = new int[20, 10];
        }
    }
}
