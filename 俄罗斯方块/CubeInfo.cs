using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
    class Cube
    {
        public int[,] cube;
        public Cube next;

        public Cube(int[,] cube, Cube next)
        {
            this.cube = cube;
            this.next = next;
        }
    }
    class CubeInfo
    {
        public static Cube cube11;
        public static Cube cube12;

        public CubeInfo()
        {
            cube11 = new Cube(
                new int[4, 4]
                {
                    {0,0,0,0},
                    {1,2,1,1},
                    {0,0,0,0},
                    {0,0,0,0},
                }, cube12);
            cube12 = new Cube(
                new int[4, 4]
                {
                    {0,1,0,0},
                    {0,2,0,0},
                    {0,1,0,0},
                    {0,1,0,0},
                }, cube11);
        }
    }
}