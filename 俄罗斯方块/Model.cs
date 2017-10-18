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

        public void CreateCube(int index)
        {
            switch (index)
            {
                case 0:
                    assignment(CubeInfo.cube11.cube);
                    break;
                case 1:
                    assignment(CubeInfo.cube12.cube);
                    break;
            }
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

        void assignment(int[,] cube)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game.instance.table[i, j + 3] * cube[i, j] != 0)
                    {
                        Game.instance.GameIsOver = true;
                        return;
                    }
                    Game.instance.table[i, j + 3] = cube[i, j];
                }
            }
        }
    }
}
