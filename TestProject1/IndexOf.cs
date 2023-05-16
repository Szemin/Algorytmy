using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class IndexOf
    {
        //algorytm zwracający indeks na którym jest konkretny znak
        public static int Indexof(string napis,char znak)
        {
            for (int i = 0; i < napis.Length; i++)
            {
                if (napis[i]==znak)
                {
                    return i;                    
                }
            }
            return -1;
        }
    }
}
