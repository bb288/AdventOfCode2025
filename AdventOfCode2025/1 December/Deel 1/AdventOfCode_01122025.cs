class AdventOfCode_01122025
{
    static void Main()
    {
        string filePath = @"c:\Users\basbo\OneDrive\Documents\Bas\Repos\Advent-of-Code-C#\AdventOfCode2025\1 December\Data\data_01122025.txt";
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

    public static int NewDial(int currentDial, int clicks, char direction)
    {
        if (direction == 'L')
        {
            return currentDial - clicks;
        }
        
        return currentDial + clicks;
    }

    public static bool IsZero(int number)
    {
        if(number % 100 == 0)
        {
            return true;
        }
        return false;
    }
}