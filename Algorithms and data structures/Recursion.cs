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

        public static int TriangleSequence( int num, int sum = 0, int count = 1)
        {
            if (count == num + 1)
            {
                return sum;
            }

            return TriangleSequence(num, sum + count, count + 1);
        }

        public static int ReturnX(string word, int index = 0)
        {
            if (word[index] == 'x')
            {
                return index;
            }
            return ReturnX(word, index + 1);
        }
    }
}
