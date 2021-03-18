private static string DecodeMessage(string[] lines)
{
    var list = new List<string>();
    foreach (string line in lines)
        if (!String.IsNullOrEmpty(line))
            foreach (string word in line.Split(' '))
                if (char.IsUpper(word[0]))
                    list.Add(word);
    list.Reverse();
    return string.Join(" ", list.ToArray());
}