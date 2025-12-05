class AdventOfCode_01122025
{
    static void Main()
    {
        string filePath = @"c:\Users\basbo\OneDrive\Documents\Bas\Repos\Advent-of-Code-C#\AdventOfCode2025\5 December\Data\data_05122025.txt";
        string[] lines = File.ReadAllLines(filePath);
        int freshIngredients = 0;
        bool inputRanges =  true;
        List<string> freshRanges = [];
        List<long> ids = [];


        foreach (var line in lines)
        {
            if(line == "")
                inputRanges = false;
            else if (inputRanges)
                freshRanges.Add(line);
            else
                ids.Add(long.Parse(line));            
        }
        
        foreach (var id in ids)
        {
            if (InAnyRange(id, freshRanges))
                freshIngredients++;
        }

        Console.WriteLine(freshIngredients);
    }

    public static bool InAnyRange(long id, List<string> ranges)
    {
        foreach (var range in ranges)
        {
            long start = long.Parse(range.Split('-')[0]);
            long end = long.Parse(range.Split('-')[1]);
            if (start <= id && id <= end)
                return true;
        }
        return false;
    }
}