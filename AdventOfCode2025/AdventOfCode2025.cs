class AdventOfCode2025
{
    static void Main()
    {
        string filePath = @"c:\Users\basbo\OneDrive\Documents\Bas\Repos\Advent-of-Code-C#\AdventOfCode2025\1 December\Data\testdata_01122025.txt";
        string[] lines = File.ReadAllLines(filePath);
        int dial = 50;
        int countZeros = 0;

        foreach (var line in lines)
        {
            int clicks = int.Parse(line.Substring(1));
            dial = NewDial(dial, clicks, line[0]);
            if (IsZero(dial))
            {
                countZeros++;
            }
        }

        Console.WriteLine(countZeros);
    }
}