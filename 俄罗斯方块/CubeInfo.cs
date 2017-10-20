using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
    public class Cube
    {
        public int[,] cube;
        public Cube next;
        public int cubeID;
        public Cube(int[,] cube,int id)
        {
            this.cube = cube;
            this.next = next;
            this.cubeID = id;
        }
    }
    class CubeInfo
    {
        public static CubeInfo instance;
        public Cube cube11;
        public Cube cube12;
        public Cube cube21;
        public Cube cube31;
        public Cube cube32;
        public Cube cube33;
        public Cube cube34;
        public Cube cube41;
        public Cube cube42;
        public Cube cube43;
        public Cube cube44;
        public Cube cube51;
        public Cube cube52;
        public Cube cube61;
        public Cube cube62;
        public Cube cube71;
        public Cube cube72;
        public Cube cube73;
        public Cube cube74;

        public CubeInfo()
        {
            instance = this;
            cube11 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,2,1,1},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },1);
            cube12 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,2,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                },2);
            cube21 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,2,1,0},
                    {0,0,1,1,0},
                    {0,0,0,0,0},
                },3);
            cube31 = new Cube(
                new int[5, 5]
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,0,2,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },4);
            cube32 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,2,1,1},
                    {0,0,1,0,0},
                    {0,0,0,0,0},
                },5);
            cube33 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,2,0,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                },6);
            cube34 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {1,1,2,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },7);
            cube41 = new Cube(
                new int[5, 5]
                {
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                    {0,1,2,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },8);
            cube42 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,2,1,1},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },9);
            cube43 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,0,2,1,0},
                    {0,0,1,0,0},
                    {0,0,1,0,0},
                },10);
            cube44 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {1,1,2,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0},
                },11);
            cube51 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,2,0,0},
                    {0,1,0,0,0},
                    {0,0,0,0,0},
                },12);
            cube52 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,1,1,0,0},
                    {0,0,2,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },13);
            cube61 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,2,1,0},
                    {0,0,0,1,0},
                    {0,0,0,0,0},
                },14);
            cube62 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,1,1,0},
                    {0,1,2,0,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },15);
            cube71 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,2,1,0},
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                },16);
            cube72 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,0,2,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0},
                },17);
            cube73 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,0,0,0},
                    {0,1,2,1,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0},
                },18);
            cube74 = new Cube(
                new int[5, 5]
                {
                    {0,0,0,0,0},
                    {0,0,1,0,0},
                    {0,1,2,0,0},
                    {0,0,1,0,0},
                    {0,0,0,0,0},
                },19);
            cube11.next = cube12;
            cube12.next = cube11;
            cube21.next = cube21;
            cube31.next = cube32;
            cube32.next = cube33;
            cube33.next = cube34;
            cube34.next = cube31;
            cube41.next = cube42;
            cube42.next = cube43;
            cube43.next = cube44;
            cube44.next = cube41;
            cube51.next = cube52;
            cube52.next = cube51;
            cube61.next = cube62;
            cube62.next = cube61;
            cube71.next = cube72;
            cube72.next = cube73;
            cube73.next = cube74;
            cube74.next = cube71;
        }
    }
}