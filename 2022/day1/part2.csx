string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

List<int> totals = new List<int>();
int current = 0;
foreach (string line in fileLines)
{
    if (line == "")
    {
        totals.Add(current);
        current = 0;
        continue;
    }

    current += int.Parse(line);
}

totals.Add(current);


totals.Sort();

int answer = 0;
for (int i = totals.Count - 1; i >= totals.Count - 3; i--)
    answer += totals[i];

Console.WriteLine(answer);