namespace 俄罗斯方块
{
    public class _Eliminate
    {
        public static void CanEliminate(out int[] a)
        {
            a = new int[20] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = 19; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Game.instance.table[i, j] != 9)
                    {
                        a[i] = 0;
                        continue;
                    }
                }
            }
        }

        public static void Eliminate(int[] a)
        {
            for (int i = 19; i >= 0; i--)
            {
                if (a[i] == 1)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            if (Game.instance.table[j, k] == 9)
                            {
                                Game.instance.table[j + 1, k] = Game.instance.table[j, k];
                            }
                        }
                    }
                    for (int j = 0; j < 10; j++)
                    {
                        for (int k = 0; k < 20; k++)
                        {
                            if (Game.instance.table[k, j] == 9)
                            {
                                Game.instance.table[k, j] = 0;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}