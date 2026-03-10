using System.Reflection;

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
        List<string> shiftedLines;
        int i = 0;

        do
        {
            int start = lineStarts[i];
            int endExclusive = (i + 1 < lineStarts.Count) ? lineStarts[i + 1] : core.Count;
            int count = endExclusive - start;

            string line = new string(
                core.Skip(start)
                    .Take(count)
                    .SelectMany(arr => arr)
                    .ToArray()
            ) + delimiter;

            shiftedLines = Shifts(line, delimiter);

            i++;
        } while (i < lineStarts.Count - 1);
    }
    private List<string> Shifts(string line, char delimiter)
    {
        List<string> circularShifts = [];
        int j = 0;
        string auxLine = line;        
        int delimOccursCount = auxLine.Count(x => x == delimiter);

        for (int i = 0; i < delimOccursCount; i++)
        {
            string fromDelimiter = auxLine[auxLine.IndexOf(delimiter, j)..auxLine.Length];
            string toDemiliter = auxLine[..auxLine.IndexOf(delimiter, j)];

            auxLine = fromDelimiter.TrimStart(delimiter).TrimStart() + " " + toDemiliter + delimiter;

            circularShifts.Add(auxLine);

            j = auxLine.IndexOf(delimiter, 0);            
        }

        return circularShifts;
    }
}