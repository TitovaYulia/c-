using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BullsAndCows.Generator
{
    public class Generator
    {
        public int[] GeneratorRand()
        {
            int[] massNumber = new int[5];
            for (int i=0; i<massNumber.Length; i++)
            {
                massNumber[i] = -1;
            }
            Random rand = new Random(DateTime.Now.Millisecond);
            int a = rand.Next(1,10);
            
            for (int i=0; i<massNumber.Length; i++)
            {
                
                while (Array.IndexOf(massNumber,a)!=-1)
                {
                    
                    a = rand.Next(0, 10);
                  

                }
                massNumber[i] = a;
            }
            return massNumber;

        }

    }
} 