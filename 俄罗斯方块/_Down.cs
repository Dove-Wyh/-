namespace 俄罗斯方块
{
    public class _Down
    {
        public static void CanDown()
        {
            for (int i = 0; i < table.GetLength(1); i++)
            {
                for (int j = 0; j < table.GetLength(0); j++)
                {
                    if (table[j, i] == 0 || table[j, i] == 2)
                    {
                        continue;
                    }
                    else if (table[j, i] == 1)
                    {
                        if (j == 0)
                        {
                            canDown = false;
                            return;
                        }
                        if (table[j - 1, i] == 0)
                        {
                            break;
                        }
                        else if (table[j - 1, i] == 1)
                        {
                            canDown = false;
                        }
                    }
                }
            }
        }

        public static void Down()
        {
            int num = 0;
            for (int i = 1; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == 1)
                    {
                        table[i, j] = 0;
                        table[i - 1, j] = 1;
                        num++;
                        if (num == 4)
                        {
                            break;
                        }
                    }
                }
                if (num == 4)
                {
                    break;
                }
            }
        }
    }
}