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