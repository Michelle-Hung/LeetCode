// See https://aka.ms/new-console-template for more information

bool IsValid(string s)
{
    //TODO: handle the scenario "[()]"
    var strings = s.ToCharArray();
    var dictionary = new Dictionary<string, string>()
    {
        {"(", ")"},
        {"[", "]"},
        {"{", "}"},
    };
    if (strings.Length % 2 != 0)
    {
        return false;
    }

    for (int i = 0; i < strings.Length; i++)
    {
        if (dictionary.TryGetValue(strings[i].ToString(), out var value) && value == strings[i + 1].ToString())
        {
            i++;
            continue;
        }

        if (dictionary.TryGetValue(strings[i+1].ToString(), out var value2) && value2 == strings[i + 2].ToString())
        {
            i = i + 2;
            continue;
        }
        
        if (dictionary.TryGetValue(strings[i+1].ToString(), out var _))
        {
            i = i + 2;
            continue;
        }

        return false;
    }

    return true;
}


Console.WriteLine(IsValid("{[]}"));