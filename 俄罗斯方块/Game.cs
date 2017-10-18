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
        public bool canDown = true;           //是否可以下落，也代表是否落到底了
        bool canTransform = true;
        bool canLeftMove = true;
        bool canRightMove = true;
        public static int[,] table;
        int cube = -1;
        
        public void CreateCube()
        {
            if (cube == -1)
            {
                //随机创建一个cube
                cube = r.Next(0, 8);
                switch (cube)
                {
                    case 0:
                        CubeInfo.Cube11();
                        break;
                    case 1:
                        CubeInfo.Cube22();
                        break;
                    case 2:
                        CubeInfo.Cube33();
                        break;
                    case 3:
                        CubeInfo.Cube44();
                        break;
                    case 4:
                        CubeInfo.Cube55();
                        break;
                    case 5:
                        CubeInfo.Cube66();
                        break;
                    case 6:
                        CubeInfo.Cube77();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (cube)
                {
                    case 0:
                        CubeInfo.Cube11();
                        break;
                    case 1:
                        CubeInfo.Cube22();
                        break;
                    case 2:
                        CubeInfo.Cube33();
                        break;
                    case 3:
                        CubeInfo.Cube44();
                        break;
                    case 4:
                        CubeInfo.Cube55();
                        break;
                    case 5:
                        CubeInfo.Cube66();
                        break;
                    case 6:
                        CubeInfo.Cube77();
                        break;
                    default:
                        break;

                }
            }
            canDown = true;
        }

        public void RealGame()
        {
            Console.Clear();
            Draw.PrintTitle();
            //创建cube
            if (!canDown)
            {
                CreateCube();
                PrintTitle();

                PrintRect();
            }
            //判断上一个方块是否落地
            while (canDown)
            {

                _Down.Down();
                CanTransform();
                CanLeftMove();
                CanRightMove();
                if (canDown)
                {
                    Down();
                }
                PrintTitle();

                PrintRect();
                Thread.Sleep(300);
            }
            //把1换成2，表示已经落到底了
            if (!canDown)
            {
                Change();
            }
        }
        
        private void Change()
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == 1)
                    {
                        table[i, j] = 2;
                    }
                }
            }
        }

        public Game()
        {
            instance = this;
            r = new Random((int)DateTime.Now.Ticks);
            table = new int[20, 10];
        }
    }
}
