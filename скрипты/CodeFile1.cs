using System;

class Beginning
{
    public int[,] creating()
    {
        int k, k1, k2, q = 0;
        //Random rand = new Random();
        Random rand = new Random((int)DateTime.Now.Ticks);

        int[,] field = new int[15, 15]{
            { 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41 },
            { 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41 },
            { 41, 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41, 41 },
            { 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41 },
            { 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41 },
            { 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41 },
            { 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41 },
            { 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41 },
            { 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41 },
            { 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41 },
            { 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41 },
            { 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41 },
            { 41, 41, 41, -1, -1, -1, -1, -1, -1, -1, -1, -1, 41, 41, 41 },
            { 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41 },
            { 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41, 41 }};
        int[] types = new int[117]{01,01,01,01,01,01,01,31,31,30,
                                   02,02,02,02,02,02,02,02,02,02,
                                   03,03,03,03,03,03,03,03,03,03,
                                   04,04,04,04,04,04,04,04,04,04,
                                   05,05,05,05,05,05,06,06,06,07,
                                   07,07,08,08,08,09,09,09,10,10,
                                   10,11,11,11,12,12,12,13,13,13,
                                   14,14,14,14,14,15,15,15,15,16,
                                   16,17,18,18,18,18,19,19,19,19,
                                   20,20,21,21,22,22,22,22,22,23,
                                   23,23,23,23,24,24,24,25,25,26,
                                   27,27,28,29,01,01,01};
        for  (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (field[i,j] == -1)
                {
                    k = rand.Next(117 - q);
                    k1 = rand.Next(117 - q - 1);
                    k2 = rand.Next(200);
                    k = (k * k1 + k2 * k1 + k * k2 + k * k + k1 * k1 + k2 * k2) % (117 - q);
                    q++;
                    field[i, j] = types[k];
                    for (int _ = 0; _ < 116 - i - k; _++)
                    {
                        if (k + _ < 117)
                        {
                            types[k + _] = types[k + _ + 1];
                        }
                        else
                        {
                            types[k + _] = -1;
                        }
                    }
                }
            }
        }


        return field;
    }
    public int[,] Recreating()
    {
        Random rand = new Random((int)DateTime.Now.Ticks);
        //Random rand = new Random();
        int x1 = 3, y1 = 3, x2 = 3, y2 = 3, qq;
        bool z = true;
        //int n = rand.Next() + 
        int n = 1000;
        int[,] field = new int[15, 15];
        //int[,] field1 = new int[15, 15];
        //int[,] field2 = new int[15, 15];
        Beginning begi = new Beginning();

        field = begi.creating();
        //System.Threading.Thread.Sleep(200);
        //field2 = begi.creating();
        for (int i = 0; i < n; i++)
        {
            x1 = rand.Next(11) + 2;
            y1 = rand.Next(11) + 2;
            x2 = rand.Next(11) + 2;
            y2 = rand.Next(11) + 2;
            while (true)
            {
                if (((x1 % 10 == 2) & (y1 % 10 == 2)) | ((x2 % 10 == 2) & (y2 % 10 == 2))){
                    x1 = rand.Next(11) + 2;
                    y1 = rand.Next(11) + 2;
                    x2 = rand.Next(11) + 2;
                    y2 = rand.Next(11) + 2;
                }
                else
                {
                    break;
                }
            }
            qq = field[x1, y1];
            field[x1, y1] = field[x2, y2];
            field[x2, y2] = qq;            
        }


        return field;
    }
    public int[,] RecreatingU()
    {
        int x1, x2, y1, y2, qq = 0, k = 0;
        x1 = x2 = y1 = y2 = 1;
        Random rand = new Random();
        Beginning Begi = new Beginning();
        int[,] field = new int[15, 15];
        int[,] field1 = new int[15, 15];
        int[,] field2 = new int[15, 15];
        field1 = Begi.creating();
        field2 = Begi.Recreating();
        field = Begi.Recreating();
        for (int i=0; i < 100; i++)
        {
            x1 = rand.Next(11) + 2;
            y1 = rand.Next(11) + 2;
            x2 = rand.Next(11) + 2;
            y2 = rand.Next(11) + 2;
            x1 = field1[x1, x2] % 11 + 2;
            y1 = field2[x1, x2] % 11 + 2;
            x2 = field1[y1, y2] % 11 + 2;
            y2 = field2[y1, y2] % 11 + 2;
            k = rand.Next(22220);


            while (true)
            {
                if (((x1 % 10 == 2) & (y1 % 10 == 2)) | ((x2 % 10 == 2) & (y2 % 10 == 2)))
                {
                    k = rand.Next(22220);
                    x1 = rand.Next(11) + 2;
                    y1 = rand.Next(11) + 2;
                    x2 = rand.Next(11) + 2;
                    y2 = rand.Next(11) + 2;
                    x1 = (field1[x1, x2] + k) % 11 +2;
                    y1 = (field2[x1, x2] + k) % 11 +2;
                    x2 = (field1[y1, y2] + k) % 11 + 2;
                    y2 = (field2[y1, y2] + k) % 11 +2 ;
                }
                else
                {
                    break;
                }
            }
            qq = field[x1, y1];
            field[x1, y1] = field[x2, y2];
            field[x2, y2] = qq;
        }
        return field;
    }
    public int[,] HRecreatingUP()
    {
        int x1, x2, y1, y2, qq = 0, k = 0, z = 1;
        x1 = x2 = y1 = y2 = 1;
        Random rand = new Random();
        Beginning Begi = new Beginning();
        int[,] field = new int[15, 15];
        int[,] field1 = new int[15, 15];
        int[,] field2 = new int[15, 15];

        field1 = Begi.Recreating();
        field2 = Begi.RecreatingU();
        field = Begi.RecreatingU();
        for (int i = 0; i < 100; i++)
        {
            z = rand.Next(121);
            x1 = (rand.Next(11) + z) % 11 + 2;
            y1 =  rand.Next(11) + 2;
            x2 =  rand.Next(11) + 2;
            y2 = (rand.Next(11) + z) % 11 + 2;
            x1 = field1[x1, x2] % 11 + 2;
            y1 = field2[x1, x2] % 11 + 2;
            x2 = field1[y1, y2] % 11 + 2;
            y2 = field2[y1, y2] % 11 + 2;
            k = rand.Next(22220);


            while (true)
            {
                if (((x1 % 10 == 2) & (y1 % 10 == 2)) | ((x2 % 10 == 2) & (y2 % 10 == 2)))
                {
                    k = rand.Next(22220);
                    x1 = rand.Next(11) + 2;
                    y1 = rand.Next(11) + 2;
                    x2 = rand.Next(11) + 2;
                    y2 = rand.Next(11) + 2;
                    x1 = (field1[x1, x2] + k + z) % 11 + 2;
                    y1 = (field2[x1, x2] + k + z) % 11 + 2;
                    x2 = (field1[y1, y2] + k + z) % 11 + 2;
                    y2 = (field2[y1, y2] + k + z) % 11 + 2;
                }
                else
                {
                    break;
                }
            }
            qq = field[x1, y1];
            field[x1, y1] = field[x2, y2];
            field[x2, y2] = qq;
        }
        return field;
    }
    public int[,] RecreatingUP()
    {
        int x1, x2, y1, y2, qq = 0, k = 0, z=1;
        x1 = x2 = y1 = y2 = 1;
        Random rand = new Random();
        Beginning Begi = new Beginning();
        int[,] field = new int[15, 15];
        int[,] field1 = new int[15, 15];
        int[,] field2 = new int[15, 15];
        
        field1 = Begi.creating();
        field2 = Begi.HRecreatingUP();
        field = Begi.HRecreatingUP();
        for (int i = 0; i < 100; i++)
        {
            x1 = rand.Next(11) + 2;
            y1 = rand.Next(11) + 2;
            x2 = rand.Next(11) + 2;
            y2 = rand.Next(11) + 2;
            x1 = field1[x1, x2] % 11 + 2;
            y1 = field2[x1, x2] % 11 + 2;
            x2 = field1[y1, y2] % 11 + 2;
            y2 = field2[y1, y2] % 11 + 2;
            k = rand.Next(22220);


            while (true)
            {
                if (((x1 % 10 == 2) & (y1 % 10 == 2)) | ((x2 % 10 == 2) & (y2 % 10 == 2)))
                {
                    k = rand.Next(22220);
                    x1 = rand.Next(11) + 2;
                    y1 = rand.Next(11) + 2;
                    x2 = rand.Next(11) + 2;
                    y2 = rand.Next(11) + 2;
                    x1 = (field1[x1, x2] + k) % 11 + 2;
                    y1 = (field2[x1, x2] + k) % 11 + 2;
                    x2 = (field1[y1, y2] + k) % 11 + 2;
                    y2 = (field2[y1, y2] + k) % 11 + 2;
                }
                else
                {
                    break;
                }
            }
            qq = field[x1, y1];
            field[x1, y1] = field[x2, y2];
            field[x2, y2] = qq;
        }
        return field;
    }

}