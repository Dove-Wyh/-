using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 俄罗斯方块
{
    class Model
    {
        public static Model instance;

        public Model()
        {
            instance = this;
        }

        public void CreateCube(Cube cube)
        {
            assignment(cube.cube);
        }

        public void Change()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Game.instance.table[i, j] != 0)
                    {
                        Game.instance.table[i, j] = 9;
                    }
                }
            }
        }

        void assignment(int[,] cube)                    //创建出新的cube之后，为矩阵赋值
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Game.instance.table[i, j + 2] * cube[i, j] != 0)
                    {
                        Game.instance.GameIsOver = true;
                        return;
                    }
                    Game.instance.table[i, j + 2] = cube[i, j];
                }
            }
        }


    }
}
