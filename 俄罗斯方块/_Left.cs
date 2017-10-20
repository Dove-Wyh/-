namespace 俄罗斯方块
{
    public class _Left
    {
        public static bool CanLeftMove()
        {
            bool canLeft = true;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Game.instance.table[i, j] == 0)
                    {
                        continue;
                    }
                    else if (Game.instance.table[i, j] == 1 || Game.instance.table[i, j] == 2)
                    {
                        if (j == 0)
                        {
                            canLeft = false;
                            return canLeft;
                        }
                        if (Game.instance.table[i, j - 1] == 0)
                        {
                            break;
                        }
                        else if (Game.instance.table[i, j - 1] == 9)
                        {
                            canLeft = false;
                            return canLeft;
                        }
                    }
                }
            }
            return canLeft;
        }

        public static void LeftMove()
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
                        Game.instance.table[i, j - 1] = 1;
                    }
                    if (Game.instance.table[i, j] == 2)
                    {
                        num++;
                        Game.instance.table[i, j] = 0;
                        Game.instance.table[i, j - 1] = 2;
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