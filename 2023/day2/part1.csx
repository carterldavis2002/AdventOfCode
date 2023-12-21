string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

int sum = 0;
int[] rgbMax = new int[3] { 12, 13, 14 };
foreach (string line in fileLines)
{ 
    string id = line.Substring(5, line.IndexOf(":") - 5);
    string[] sets = line.Substring(line.IndexOf(":") + 1).Split(';');
    bool possible = true;
    foreach (string set in sets)
    {
        string[] cubes = set.Split(',');
        int[] rgb = new int[3] { 0, 0, 0 };
        foreach (string cube in cubes)
        {
            if (cube.IndexOf("red") != -1)
                rgb[0] = int.Parse(cube.Substring(1, cube.IndexOf("red") - 1));
            else if (cube.IndexOf("green") != -1)
                rgb[1] = int.Parse(cube.Substring(1, cube.IndexOf("green") - 1));
            else
                rgb[2] = int.Parse(cube.Substring(1, cube.IndexOf("blue") - 1));
        }

        for (int i = 0; i < rgb.Length; i++)
        {
            if (rgb[i] > rgbMax[i])
                possible = false;
        }
    }

    if (possible)
        sum += int.Parse(id);
}

Console.WriteLine(sum);