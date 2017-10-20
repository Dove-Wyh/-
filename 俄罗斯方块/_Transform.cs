using System;

namespace 俄罗斯方块
{
    public class _Transform
    {
        public static _Transform instance;

        public _Transform()
        {
            instance = this;
        }

        int centerX = 0;
        int centerY = 0;
        int[,] matrix;
        Cube nextCube;

        public bool CanTransform(Cube cube)
        {
            bool canTransform = true;
            nextCube = cube.next;
            matrix = new int[5, 5];

            //以2为中心，把周围5×5的区域，复制到了一个新的矩阵中

            //找到中心2
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Game.instance.table[i, j] == 2)
                    {
                        centerX = i;
                        centerY = j;
                    }
                }
            }

            //复制到矩阵
            for (int i = centerX - 2; i < centerX + 3; i++)
            {
                for (int j = centerY - 2; j < centerY + 3; j++)
                {
                    try
                    {
                        if (Game.instance.table[i, j] != 1)//0,2,9
                        {
                            matrix[i - centerX + 2, j - centerY + 2] = Game.instance.table[i, j];
                        }

                    }
                    catch (Exception e)
                    {
                        canTransform = false;
                    }
                }
            }

            //判断能否旋转
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] * nextCube.cube[i, j] == 9)
                    {
                        canTransform = false;
                        return canTransform;
                    }
                }
            }

            return canTransform;
        }

        public void Transform()
        {
            for (int i = centerX - 2; i < centerX + 3; i++)
            {
                for (int j = centerY - 2; j < centerY + 3; j++)
                {
                    if (Game.instance.table[i, j] == 1)
                    {
                        Game.instance.table[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (nextCube.cube[i, j] == 1 || nextCube.cube[i, j] == 2)
                    {
                        matrix[i, j] = nextCube.cube[i, j];
                    }
                }
            }

            for (int i = centerX - 2; i < centerX + 3; i++)
            {
                for (int j = centerY - 2; j < centerY + 3; j++)
                {
                    //先把next的值赋给matrix
                    Game.instance.table[i, j] = matrix[i - centerX + 2, j - centerY + 2];
                }
            }
        }
    }
}