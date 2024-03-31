

string GetLettersFromString(string s)
{
    string letters = "";
    foreach (var e in s)
    {
        if(char.IsAsciiLetter(e))
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string resalt = GetLettersFromString(str);
Console.WriteLine(resalt);
















