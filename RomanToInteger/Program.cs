

public class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(RomanToInt("MCMXCIV").ToString());
        Console.ReadLine();
    }

    public static int RomanToInt(string s)
    {
        int romanInt = 0;

        var myArray = s.ToArray();
        var array = myArray.Reverse();

        char previosChar = 'o';

        foreach (var item in array)
        {
            if (item == 'o')
            {
                romanInt = SymbolToInt(item);
                previosChar = item;
                continue;
            }

            if (item == previosChar)
            {
                romanInt += SymbolToInt(item);
                continue;
            }

            if (item == 'I' && (previosChar == 'V' || previosChar == 'X'))
            {
                romanInt -= SymbolToInt(item);
                continue;
            }

            if (item == 'X' && (previosChar == 'L' || previosChar == 'C'))
            {
                romanInt -= SymbolToInt(item);
                continue;
            }

            if (item == 'C' && (previosChar == 'D' || previosChar == 'M'))
            {
                romanInt -= SymbolToInt(item);
                continue;
            }

            romanInt += SymbolToInt(item);

            previosChar = item;
        }

        return romanInt;
    }

    public static int SymbolToInt(char c)
    {
        int symbolInt = 0;

        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
        }

        return symbolInt;
    }
}