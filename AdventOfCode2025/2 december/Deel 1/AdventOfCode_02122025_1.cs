class AdventOfCode_01122025
{
    static void Main()
    {
        string filePath = @"c:\Users\basbo\OneDrive\Documents\Bas\Repos\Advent-of-Code-C#\AdventOfCode2025\2 December\Data\data_02122025.txt";
        string[] lines = File.ReadAllLines(filePath);
        string[] ranges = lines[0].Split(',');
        long invalidIds = 0;

        foreach (var range in ranges)
        {
            Console.WriteLine(range);
            long firstId = long.Parse(range.Split('-')[0]);
            long lastId = long.Parse(range.Split('-')[1]);
            long currentId = firstId;
            while (currentId <= lastId)
            {
                if (IsInvalid(currentId.ToString()))
                    invalidIds += currentId;
                currentId++;
            }
        }
        Console.WriteLine(invalidIds);
    }
    
    public static bool IsInvalid(string id)
    {
        if (id.Length % 2 != 0)
        {
            return false;
        }
        string firstPart = id.Substring(id.Length / 2);
        string lastPart = id.Substring(0, id.Length / 2);

        if (firstPart.Equals(lastPart))
        {
            return true;
        }
        return false;
    }
}