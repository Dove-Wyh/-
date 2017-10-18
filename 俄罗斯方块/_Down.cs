namespace 俄罗斯方块
{
    public class _Down
    {
        public static bool CanDown()
        {
            bool canDown = true;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 19; j >= 0; j--)
                {
                    if (Game.instance.table[j, i] == 0)
                    {
                        continue;
                    }
                    else if (Game.instance.table[j, i] == 1 || Game.instance.table[j, i] == 2)
                    {
                        if (j == 19)
                        {
                            canDown = false;
                            return canDown;
                        }
                        if (Game.instance.table[j + 1, i] == 0)
                        {
                            break;
                        }
                        else if (Game.instance.table[j + 1, i] == 9)
                        {
                            canDown = false;
                            return canDown;
                        }
                    }
                }
            }
            return canDown;
        }

        public static void Down()
        {
            int num = 0;
            for (int i = 19; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Game.instance.table[i, j] == 1)
                    {
                        num++;
                        Game.instance.table[i, j] = 0;
                        Game.instance.table[i + 1, j] = 1;
                    }
                    if (Game.instance.table[i, j] == 2)
                    {
                        num++;
                        Game.instance.table[i, j] = 0;
                        Game.instance.table[i + 1, j] = 2;
                    }
                    if (num == 4)
                    {
                        return;
                    }
                }
            }
        }
    }
}