using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Algorytm1  //zmiana jednego znaku w napisie na drugi
    {
       public static string Repleace(string tekst, char znak, char repleace) 
        {
            char[] znaki = tekst.ToCharArray();  //tablica znaków = tekst.ToCharArray() żeby pracować na kopii stringa na charArray
            for (int i = 0; i < znaki.Length; i++)
            {
                if (znaki[i] == znak)  //wyszukiwanie odpowiedniego indeksu na którym jest znak do podmiany
                {
                    znaki[i] = repleace; //podmiana znaku na skopiowanym stringu jako tablica 
                }              
            }
            return new string(znaki); //zwracanie nowego stringa na podstawie tablicy znaków która jest kopią stringa
        }
    }
}
