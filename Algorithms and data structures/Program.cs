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



List<int> list = new List<int> { 1, 2, 4, 7, 9, 3, 6, 5 };
list = Sorting.SortList(list);

for (int i = 0;  i < list.Count; i++)
{
    if (list[i + 1] == list[i] + 1)
    {
        continue;
    } else
    {
        Console.WriteLine(list[i] + 1);
        break;
    }
         
}



