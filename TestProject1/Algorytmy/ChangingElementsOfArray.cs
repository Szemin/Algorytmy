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
                    return i;   //jeżeli parzysta zwraca indeks od i
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
                    return i;      //jeżeli nieparzysta zwraca indeks od i
                }
            }
            return -1;
        }

        public void Repleace(int[] tab, int index1, int index2) 
        {
            //sprawdzanie czy index1 <0 albo >= długości tablicy tak samo index2
            if (index1 < 0 || index1 >= tab.Length || index2 < 0 || index2 >= tab.Length) return; 
            
            int temp = tab[index1];    //zamiana wartości z index1 na index2 i na odwrót
            tab[index1] = tab[index2];
            tab[index2] = temp;            
        }

        public bool RepleaceEvenOdd(int[] tab)
        {
            int even = IsFistEven(tab);   //przypisywanie do even funkcji sprawdzającej czy parzysta na podstawie tablicy
            int odd = IsFistOdd(tab);   //przypisywanie do odd funkcji sprawdzającej czy nieparzysta na podstawie tablicy
            if (even == -1 || odd == -1)
            {
                return false;   //jeżeli nie to zwraca -1
            }
            Repleace(tab, even, odd);    //zmiana miejsc na indeksach 
            return true;
        }

    }
}
