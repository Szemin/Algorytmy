using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Algorytmy
{
    public class Vowels_and_consonants
    {
        public bool IsMoreVowels(string word)
        {
            word = word.ToLower();
            //char[] znaki = word.ToCharArray();
            //char[] chars = new char[] { 'a','e','i','o','u'};
            string vowels = "aeiou";   //string z samogłoskami
            int howManyVowels = 0;    //zmienna zliczająca samo
            int howManyConsonants = 0;  //zmienna zliczająca spół 

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];    //tablica z konkretnym znakiem przypisując do niej słowo z indeksem od i
                if (char.IsLetter(currentChar))   //sprawdzanie czy char to litera z tablicy znaków
                {
                    if (vowels.Contains(currentChar))   //jeżeli zmienna samogłoski zawiera samogłoskę licznik += 1
                    {
                        howManyVowels++;
                    }
                    else                                //jeżeli spółgłoska zwiększa licznik += 1
                    {
                        howManyConsonants++;
                    }
                }
            }
            return howManyVowels > howManyConsonants;    //zwraca prawdę gdy więcej jest samo niż spół

        }
    }
}
