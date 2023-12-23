string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

int prioritySum = 0;
foreach (string line in fileLines)
{
    HashSet<char> firstCompartment = new HashSet<char>();
    HashSet<char> secondCompartment = new HashSet<char>();

    for (int i = 0; i < line.Length; i++)
    {
        if (i < line.Length / 2)
            firstCompartment.Add(line[i]);
        else
            secondCompartment.Add(line[i]);
    }

    firstCompartment.IntersectWith(secondCompartment);
    foreach (char c in firstCompartment)
        prioritySum += Char.ToLower(c) == c ? (int)c % 32 : ((int)c % 32) + 26;
}

Console.WriteLine(prioritySum);