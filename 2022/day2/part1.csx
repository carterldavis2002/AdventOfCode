string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

int totalScore = 0;
foreach (string line in fileLines)
{
    int roundScore = 0;

    switch (line[2])
    {
        case 'X':
            roundScore += 1;
            break;
        case 'Y':
            roundScore += 2;
            break;
        default:
            roundScore += 3;
            break;
    }

    if ((char) (line[0] + 23) == line[2])
        roundScore += 3;
    else if (line == "A Y" || line == "B Z" || line == "C X")
        roundScore += 6;

    totalScore += roundScore;
}

Console.WriteLine(totalScore);