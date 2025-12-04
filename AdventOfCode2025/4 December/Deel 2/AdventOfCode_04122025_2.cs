class AdventOfCode_01122025
{
    static void Main()
    {
        string filePath = @"c:\Users\basbo\OneDrive\Documents\Bas\Repos\Advent-of-Code-C#\AdventOfCode2025\4 December\Data\data_04122025.txt";
        string[] lines = File.ReadAllLines(filePath);
        int paperRolls = 0;
        int changes = 0;

        do
        {
            changes = 0;
            for (var i = 0; i < lines.Count(); i++)
            {
                for (var j = 0; j < lines[0].Length; j++)
                {
                    if (lines[i][j] != '@')
                        continue;
                    
                    int adjecentRolls = 0;
                    if (i != 0)
                    {
                        if (j != 0 && lines[i-1][j-1] == '@')
                            adjecentRolls ++;
                        if (lines[i-1][j] == '@')
                            adjecentRolls++;
                        if (j != lines[i].Length - 1 && lines[i-1][j+1] == '@')
                            adjecentRolls++;
                    }
                    if (j != 0 && lines[i][j-1] == '@')
                        adjecentRolls++;
                    if (j != lines[i].Length - 1 && lines[i][j+1] == '@')
                        adjecentRolls++;
                    if (i != lines.Count() - 1)
                    {
                        if (j != 0 && lines[i+1][j-1] == '@')
                            adjecentRolls++;
                        if (lines[i+1][j] == '@')
                            adjecentRolls++;
                        if (j != lines[i].Length - 1 && lines[i+1][j+1] == '@')
                            adjecentRolls++;
                    }

                    if (adjecentRolls < 4)
                    {
                        paperRolls++;
                        changes++;
                        lines[i] = lines[i].Substring(0, j) + 'X' + lines[i].Substring(j+1);
                    }
                }
            }
        }
        while (changes != 0);

        Console.WriteLine(paperRolls);
    }
}