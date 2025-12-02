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
        for (int i = 1; i < id.Length; i++)
        {
            if (id.Length % i != 0)
                continue;
            string firstPart = id.Substring(0, i);
            for (int j = 1; j < id.Length / i; j++)
            {
                string checkingPart = id.Substring(i * j, i);
                if (firstPart.Equals(checkingPart))
                    if (j == (id.Length / i) - 1)
                        return true;
                    else
                        continue;
                else
                    break;
            }
        }

        return false;
    }
}