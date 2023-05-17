using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Algorytmy
{
    public class Akronim
    {
        public string Akrronim(string word)
        {
            string[] words = word.Split(' ');
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                result += currentWord[0];
            }
            return result;
        }
    }
}
