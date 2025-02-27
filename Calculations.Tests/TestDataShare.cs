using Xunit;

namespace Calculations.Tests;

public static class TestDataShare
{
    public static TheoryData<int, bool> IsOddOrEvenData {
        get{
            return new() 
            {
                { 1, true },
                { 2, false }
            };
        }
    }

    public static TheoryData<int, bool> IsOddOrEvenExternalData {
        get {
            var allLines = File.ReadAllLines("IsOddOrEvenTestData.txt");
            var td = new TheoryData<int, bool>();
            foreach (var line in allLines)
            {
                var lineSplit = line.Split(',');
                td.Add(int.Parse(lineSplit[0]), bool.Parse(lineSplit[1]));
            }
            return td;
        }
    }
}