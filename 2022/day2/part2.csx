string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

int totalScore = 0;
foreach (string line in fileLines)
{
    int roundScore = 0;
    char chosen = ' ';

    switch (line[2])
    {
        case 'X':
            switch (line[0])
            {
                case 'A':
                    chosen = 'C';
                    break;
                case 'B':
                    chosen = 'A';
                    break;
                case 'C':
                    chosen = 'B';
                    break;
            }
            break;
        case 'Y':
            chosen = line[0];
            roundScore += 3;
            break;
        default:
            switch (line[0])
            {
                case 'A':
                    chosen = 'B';
                    break;
                case 'B':
                    chosen = 'C';
                    break;
                case 'C':
                    chosen = 'A';
                    break;
            }
            roundScore += 6;
            break;
    }
    
    switch (chosen)
    {
        case 'A':
            roundScore += 1;
            break;
        case 'B':
            roundScore += 2;
            break;
        default:
            roundScore += 3;
            break;
    }

    totalScore += roundScore;
}

Console.WriteLine(totalScore);