string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

int sum = 0;
foreach (string line in fileLines)
{
    char[] digits = new char[2] { '0', '0' };
    int cnt = 0;
    foreach (char c in line)
    {
        if (char.IsDigit(c))
        { 
            cnt++;
            digits[cnt == 1 ? 0 : 1] = c;
        }
    }

    if (cnt == 1)
        digits[1] = digits[0];

    sum += int.Parse($"{digits[0]}{digits[1]}");
}

Console.WriteLine(sum);