namespace Decomposing;
public class Alphabetizing
{   
    public List<(int originalLineNumber, int startingAddress)> sortedCoreInPairs;
    public Alphabetizing()
    {
        sortedCoreInPairs = [];
    }
    public void StoreSorted(string core, List<(int originalLineNumber, int startingAddress)> corePairs)
    {       
        sortedCoreInPairs = [.. corePairs]; 
        sortedCoreInPairs.Sort((a, b) => core[a.startingAddress].CompareTo(core[b.startingAddress]));
    }
}