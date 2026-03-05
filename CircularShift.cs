using System.Runtime.InteropServices;

namespace Decomposing;
public class CircularShift
{
    public List<(int originalLineNumber, int startingAddress)> CoreInPairs;
    public CircularShift()
    {
        CoreInPairs = [];
    }
    public void StoreWordsInPairs(List<char[]> core, List<int> lineStarts, char delimiter)
    {       
        for (int i = 0; i < lineStarts.Count; i++)
        {
            int start = lineStarts[i];
            int endExclusive = (i + 1 < lineStarts.Count) ? lineStarts[i + 1] : core.Count;
            int count = endExclusive - start;

            string line = new string(
                core.Skip(start)
                    .Take(count)
                    .SelectMany(arr => arr)
                    .ToArray()
            );
            
            // char firstChar;

            // for (int j = 0; j < length; j++)
            // {
                
            // }

            var nextIndices = new List<int>();
            for (int j = line.IndexOf(delimiter); j != -1; j = line.IndexOf(delimiter, j + 1))
            {
                if (j + 1 < line.Length) nextIndices.Add(j);
            }
        }
    }
}