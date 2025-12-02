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
            int oldDial = dial;
            int clicks = int.Parse(line.Substring(1));
            if (clicks > 100)
            {
                countZeros += clicks / 100;
                clicks %= 100;
            }

            (bool passedZero, dial) = TurnDial(dial, clicks, line[0]);

            if (passedZero)
            {
                countZeros++;
            }
    
            Console.WriteLine($"OldDial = {oldDial}, newDial = {dial}, passedZero = {passedZero}, aantalZeros = {countZeros}");
        }
        Console.WriteLine(countZeros);
    }

    public static (bool, int) TurnDial(int currentDial, int clicks, char direction)
    {
        int newDial;
        if (direction == 'L')
        {
            newDial = currentDial - clicks;
            if (currentDial == 0 && newDial < 0)
            {
                return (false, newDial + 100);                                
            }
            else if (newDial < 0)
            {
                return(true, newDial + 100);
            }
            else if (newDial == 0)
            {
                return(true, newDial);
            }
            else
            {
                return (false, newDial);                
            }
        }
        
        newDial = currentDial + clicks;
        if (newDial >= 100)
        {
            return(true, newDial - 100);
        }
        else
        {
            return(false, newDial);
        }
    }
}