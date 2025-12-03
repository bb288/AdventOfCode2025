class AdventOfCode_01122025
{
    static void Main()
    {
        string filePath = @"c:\Users\basbo\OneDrive\Documents\Bas\Repos\Advent-of-Code-C#\AdventOfCode2025\3 December\Data\data_03122025.txt";
        string[] lines = File.ReadAllLines(filePath);
        long joltage = 0;

        foreach (var line in lines)
        {
            joltage += SearchHighstNumber(line);
        }

        Console.WriteLine(joltage);
    }

    public static int SearchHighstNumber(string bank)
    {
        int i = 9;
        string highNumber = "";
        string lastNumber = "";
        while (i >= 0)
        {
            string iString = i.ToString();
            int count = bank.Count(l => l == iString[0]);
            if (count == 0)
            {
                i--;
                continue;                
            }
            
            if (highNumber == "" && lastNumber == "")
            {
                if (count > 1)
                    return int.Parse(iString+iString);
                else if (count == 1 && bank.IndexOf(iString) != bank.Length - 1)
                {
                    highNumber = iString;
                    bank = bank.Substring(bank.IndexOf(iString));
                    i--;
                    continue;
                }
                else if (count == 1)
                {
                    lastNumber = iString;
                    i--;
                    continue;
                }
            }
            else
            {
                if (count >= 1)
                {
                    if (lastNumber == "")
                        return int.Parse(highNumber+iString);
                    else
                        return int.Parse(iString+lastNumber);
                }
            }
            
            i--;
            continue;

        }

        return 0;
    }
}