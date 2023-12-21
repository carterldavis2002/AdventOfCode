string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

int max = 0;
int current = 0;
foreach (string line in fileLines)
{
    if (line == "")
    {
        if (current > max)
            max = current;

        current = 0;
        continue;
    }

    current += int.Parse(line);
}

if (current > max)
    max = current;

Console.WriteLine(max);