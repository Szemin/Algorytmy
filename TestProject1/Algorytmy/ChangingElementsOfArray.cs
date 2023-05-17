using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Algorytmy
{
    public class ChangingElementsOfArray
    {
        public int IsFistEven(int[] tab) //numer indeksu
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 0)  // if((tab[i] & 1) == 0)
                {
                    return i;
                }
            }
            return-1;
        }
        public int IsFistOdd(int[] tab) //numer indeksu
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 1)  // if((tab[i] & 1) != 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Repleace(int[] tab, int index1, int index2) 
        {
            if (index1 < 0 || index1 >= tab.Length || index2 < 0 || index2 >= tab.Length) return;
            
            int temp = tab[index1];
            tab[index1] = tab[index2];
            tab[index2] = temp;
            
        }

    }
}
