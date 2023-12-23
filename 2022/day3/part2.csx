string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

List<string> currentGroup = new List<string>();
int lineCount = 0;
int prioritySum = 0;
foreach (string line in fileLines)
{
    currentGroup.Add(line);

    lineCount++;
    if (lineCount % 3 == 0)
    {
        HashSet<char> first = new HashSet<char>();
        for (int i = 0; i < currentGroup[0].Length; i++)
            first.Add(currentGroup[0][i]);

        HashSet<char> second = new HashSet<char>();
        for (int i = 0; i < currentGroup[1].Length; i++)
            second.Add(currentGroup[1][i]);

        HashSet<char> third = new HashSet<char>();
        for (int i = 0; i < currentGroup[2].Length; i++)
            third.Add(currentGroup[2][i]);

        first.IntersectWith(second);
        first.IntersectWith(third);

        foreach (char c in first)
            prioritySum += Char.ToLower(c) == c ? (int)c % 32 : ((int)c % 32) + 26;

        currentGroup.Clear();
    }
}

Console.WriteLine(prioritySum);