using System.Text.RegularExpressions;

string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

int sum = 0;
foreach (string line in fileLines)
{
    Regex regex = new Regex(@"(?=(\d|zero|one|two|three|four|five|six|seven|eight|nine))", RegexOptions.Compiled | RegexOptions.IgnoreCase);
    MatchCollection matches = regex.Matches(line);
    if (matches.Count == 0)
        continue;

    int[] indexes = new int[2] { matches[0].Index, matches[matches.Count - 1].Index };
    char[] digits = new char[2] { '0', '0' };

    for (int i = 0; i < indexes.Length; i++)
    {
        if (Char.IsDigit(line[indexes[i]]))
            digits[i] = line[indexes[i]];
        else if (line.Substring(indexes[i]).IndexOf("zero") == 0)
            digits[i] = '0';
        else if (line.Substring(indexes[i]).IndexOf("one") == 0)
            digits[i] = '1';
        else if (line.Substring(indexes[i]).IndexOf("two") == 0)
            digits[i] = '2';
        else if (line.Substring(indexes[i]).IndexOf("three") == 0)
            digits[i] = '3';
        else if (line.Substring(indexes[i]).IndexOf("four") == 0)
            digits[i] = '4';
        else if (line.Substring(indexes[i]).IndexOf("five") == 0)
            digits[i] = '5';
        else if (line.Substring(indexes[i]).IndexOf("six") == 0)
            digits[i] = '6';
        else if (line.Substring(indexes[i]).IndexOf("seven") == 0)
            digits[i] = '7';
        else if (line.Substring(indexes[i]).IndexOf("eight") == 0)
            digits[i] = '8';
        else if (line.Substring(indexes[i]).IndexOf("nine") == 0)
            digits[i] = '9';
    }

    sum += int.Parse($"{digits[0]}{digits[1]}");
}

Console.WriteLine(sum);