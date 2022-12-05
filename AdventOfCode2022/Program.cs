using AdventOfCode2022.Week1.Day1;

using System.Security.Cryptography.X509Certificates;

// See https://aka.ms/new-console-template for more information
Console.WriteLine(Day1Code.codetest);
string check = Day1Code.codetest.Replace("\n", "");
check = check.Replace("\r", "");
List<string> newtest = Day1Code.codetest.Split("\n").ToList();

Console .WriteLine(newtest.Count);
List<int> newnewtest = new List<int>();
foreach(string test in newtest)
{
    if (test != "")
    {
        newnewtest.Add(int.Parse(test));
    }
}
Console.WriteLine(newtest.Count);