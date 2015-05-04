using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //Marijn Nijsse
        //4286006
        static void Main(string[] args)
        {
            long baseExp, factor, maxLvl, playerExp, l, h, m, b;

            string playerExpString;
            string rawData = Console.ReadLine();
            string[] splitData = rawData.Split(' ');

            baseExp = long.Parse(splitData[0]);
            factor = long.Parse(splitData[1]);
            maxLvl = long.Parse(splitData[2]);
            b = baseExp;

            if(maxLvl > 10000000)
                maxLvl = 10000000;

            long[] levels = new long[maxLvl];

            for (int i = 0; i < maxLvl; i++)
            {
                levels[i] = b;
                b += (b + factor - 1) / factor;
            }

            playerExpString = Console.ReadLine();

            while(!String.IsNullOrEmpty(playerExpString))
            {
                playerExp = long.Parse(playerExpString);

                l = 0;
                h = maxLvl;

                if (playerExp >= levels[maxLvl - 2])
                {
                    Console.WriteLine(maxLvl);
                    playerExpString = Console.ReadLine();
                    continue;
                }

                while(l < h)
                {
                    m = (l + h) / 2;

                    if (playerExp <= levels[m])
                        h = m;
                    else
                        l = m + 1;
                }

                if (playerExp < levels[h])
                    Console.WriteLine(h + 1);
                else
                    Console.WriteLine(h + 2);

                playerExpString = Console.ReadLine();
            }                       
        }
    }
}
