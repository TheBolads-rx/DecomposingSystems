namespace Decomposing;
public class Alphabetizing
{   
    public List<(int originalLineNumber, int startingAddress)> sortedCoreInPairs;
    public Alphabetizing()
    {
        sortedCoreInPairs = [];
    }
    public void storeSorted(string core, List<(int originalLineNumber, int startingAddress)> corePairs)
    {       
        corePairs.Sort((a, b) => core[a.startingAddress].CompareTo(core[b.startingAddress]));
        sortedCoreInPairs.Clear();
        sortedCoreInPairs.AddRange(corePairs);
    }
}