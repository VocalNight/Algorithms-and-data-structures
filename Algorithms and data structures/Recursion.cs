using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_data_structures
{
    public static class Recursion
    {

        public static int NumberOfLetters(List<string> words, int index=0, int count=0)
        {
            if (index == words.Count)
            {
                return count;
            }

            return NumberOfLetters(words, index + 1, count + words[index].Length);
        }
    }
}
