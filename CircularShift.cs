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
        int i = 0;

        do
        {
            string fromDelimiter = line[line.IndexOf(delimiter, i)..line.Length];
            string toDemiliter = line[i..line.IndexOf(delimiter, i)];

            circularShifts.Add(fromDelimiter.TrimStart() + " " + toDemiliter + delimiter);

            i = line.IndexOf(delimiter, i);
        } while (i != -1);

        return circularShifts;
    }
}