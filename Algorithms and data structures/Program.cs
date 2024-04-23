using Algorithms_and_data_structures;
using System.Collections;

List<int> check( List<int> a, List<int> b )
{
    var dic = new Dictionary<int, bool>();
    List<int> inter = new List<int>();
    List<int> biggerArray = null;
    List<int> lowerArray = null;

    if (a.Count > b.Count )
    {
        biggerArray = a;
        lowerArray = b;
    } else
    {
        biggerArray = b;
        lowerArray = a;
    }

    foreach (int i in biggerArray)
    {
        dic[i] = true;
    }

    foreach(int i in lowerArray)
    {
        if (dic[i])
        {
            inter.Add(i);
        }
    }

    return inter;
}

string check2( string[] a)
{

    Dictionary<string, bool> dict = new Dictionary<string, bool>();


    foreach (string s in a)
    {
        if (dict[s])
        {
            return s;
        }

        dict[s] = true;
    }

    return "No duplicates";
}

string stackCheck(string a)
{
    Stack stack = new Stack();
    string inverted = null;

    foreach (char c in a)
    {
        stack.Push(c);
    }

    foreach (char c in stack)
    {
        inverted.Append(c);

    }

    return inverted;
}

Console.WriteLine(Recursion.NumberOfLetters(new List<string>() { "a", "ncskd", "4854", "saldjklasd"}));