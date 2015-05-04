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
            long baseExp, factor, maxLvl, playerExp, k;

            string playerExpString;
            string rawData = Console.ReadLine();
            string[] splitData = rawData.Split(' ');

            baseExp = long.Parse(splitData[0]);
            factor = long.Parse(splitData[1]);
            maxLvl = long.Parse(splitData[2]);
            k = baseExp;
            playerExp = 0;

            if(maxLvl > 10000000)
                maxLvl = 10000000;

            playerExpString = Console.ReadLine();

            while(!String.IsNullOrEmpty(playerExpString))
            {
                    playerExp = long.Parse(playerExpString);

                    for (long j = 1; j < maxLvl + 1; j++)
                    {
                        if (playerExp - k < 0)
                        {
                            Console.WriteLine(j);//level = j;
                            k = baseExp;
                            j = maxLvl;
                            break;
                        }
                        else if (j == maxLvl)//check this too
                        {
                            Console.WriteLine(maxLvl);//level = 1;
                        }

                        k += (k + factor - 1) / factor;
                    }

                    playerExpString = Console.ReadLine();
                //The faster way would be to substract the extra (5 when going from 10 to 15) every round, so no k = baseExp is needed
            }                       
        }
    }
}
