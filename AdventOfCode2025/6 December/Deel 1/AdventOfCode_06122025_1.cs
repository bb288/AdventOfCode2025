class AdventOfCode_01122025
{
    static void Main()
    {
        string filePath = @"c:\Users\basbo\OneDrive\Documents\Bas\Repos\Advent-of-Code-C#\AdventOfCode2025\6 December\Data\data_06122025.txt";
        string[] lines = File.ReadAllLines(filePath);
        long totalSum = 0;
        List<string[]> grid = new();

        foreach (var line in lines)
        {
            grid.Add(line.Split(" ", StringSplitOptions.RemoveEmptyEntries));
        }

        for(var j = 0; j < grid[0].Count(); j++)
        {
            long problemAnswer = 0;
            if (grid[grid.Count() - 1][j] == "+")
            {
                for(var i = grid.Count() - 2; i >= 0; i--)
                {
                    problemAnswer += int.Parse(grid[i][j]);
                }                
            }
            else if (grid[grid.Count() - 1][j] == "*")
            {
                problemAnswer = 1;
                for(var i = grid.Count() - 2; i >= 0; i--)
                {
                    problemAnswer *= int.Parse(grid[i][j]);
                }                
            }
            totalSum += problemAnswer;
            Console.WriteLine(problemAnswer);
        }
        Console.WriteLine(totalSum);
    }        
}