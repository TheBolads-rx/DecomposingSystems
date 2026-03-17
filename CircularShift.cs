namespace Decomposing;
public class CircularShift
{
    public List<(int originalLineNumber, int startingAddress)> CoreInPairs;
    public CircularShift()
    {
        CoreInPairs = [];
    }
    public void StoreWordsInPairs(string core, List<int> lineStarts, char delimiter)
    {       
        int lineEnd;

        for (int i = 0; i < lineStarts.Count; i++)
        {
            lineEnd = (i != lineStarts.Count - 1) ? lineStarts[i + 1] : core.Length;
            string line = core[lineStarts[i]..lineEnd];
            int wordOffSet = lineStarts[i];

            foreach (string word in line.Split(delimiter))
            {
                CoreInPairs.Add((i + 1, wordOffSet));
                wordOffSet += word.Length + 2;
            }
        }
    }
}