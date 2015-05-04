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
            long baseExp, factor, maxLvl, playerExp, l, n;

            string playerExpString;
            string rawData = Console.ReadLine();
            string[] splitData = rawData.Split(' ');

            baseExp = long.Parse(splitData[0]);
            factor = long.Parse(splitData[1]);
            maxLvl = long.Parse(splitData[2]);
            l = baseExp;
            //n = baseExp;
            n = factor - 1;


            if(maxLvl > 10000000)
                maxLvl = 10000000;

            playerExpString = Console.ReadLine();

            while(!String.IsNullOrEmpty(playerExpString))
            {
                    playerExp = long.Parse(playerExpString);
                    
                    long j = 0;    

                    while (playerExp >= 0)
                    {
                        j++;

                        if (j == maxLvl)
                            break;

                        if (l - playerExp > 0)
                            break;
                        //playerExp -= n;

                        //n = ((l + factor - 1) / factor);
                        l = l + ((l + n) / factor);
                    }
                    
                    Console.WriteLine(j);
                    l = baseExp;
                    //n = baseExp;

                    playerExpString = Console.ReadLine();
                //The faster way would be to substract the extra (5 when going from 10 to 15) every round, so no k = baseExp is needed
            }                       
        }
    }
}
