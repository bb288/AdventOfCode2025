class AdventOfCode_01122025
{
    static void Main()
    {
        string filePath = @"c:\Users\basbo\OneDrive\Documents\Bas\Repos\Advent-of-Code-C#\AdventOfCode2025\6 December\Data\data_06122025.txt";
        string[] lines = File.ReadAllLines(filePath);
        long totalSum = 0;
        long problemAnswer = 0;
        bool add = false;
        bool multiply = false;


        for(var j = 0; j < lines[0].Count(); j++)
        {
            string stringGetal = "";

            if (lines[lines.Count() - 1][j] == '+')
            {
                problemAnswer = 0;
                add = true;                
            }
            else if (lines[lines.Count() - 1][j] == '*')
            {
                problemAnswer = 1;
                multiply = true;                
            }
            
            for(var i = 0; i < lines.Count() - 1; i++)
            {
                stringGetal += lines[i][j];
            }
            
            if (string.IsNullOrWhiteSpace(stringGetal))
            {
                add = false;
                multiply = false;
                Console.WriteLine(problemAnswer);
                totalSum += problemAnswer;
                continue;
            }
            
            int getal = int.Parse(stringGetal.Trim());

            if (add)
            {
                problemAnswer += getal;
            }
            else if (multiply)
            {
                problemAnswer *= getal;
            }
        }
        totalSum += problemAnswer;
        Console.WriteLine(totalSum);
    }        
}