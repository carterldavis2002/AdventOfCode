string fileName = "input.txt";
string[] fileLines = File.ReadAllLines(fileName);

int sum = 0;
foreach (string line in fileLines)
{
    string[] sets = line.Substring(line.IndexOf(":") + 1).Split(';');
    int[] rgbMax = new int[3] { 0, 0, 0 };
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
                rgbMax[i] = rgb[i];
        }
    }

    int power = 1;
    for (int i = 0; i < rgbMax.Length; i++)
    {
        power *= rgbMax[i];
    }
    sum += power;
}

Console.WriteLine(sum);