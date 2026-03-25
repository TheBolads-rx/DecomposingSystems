namespace Decomposing;
public class Output
{
   public string[] OutputCircularShifts(string core, List<int> lineStarts, List<(int originalLineNumber, int startingAddress)> sortedIndex)
   {    
        List<string> output = [];       
        int lineEnding;

        for (int i = 0; i < sortedIndex.Count; i++)
        {
            if (sortedIndex[i].originalLineNumber == (lineStarts.Count - 1))
            {
                lineEnding = core.Length - 1;
            }
            else
            {
                lineEnding = lineStarts[sortedIndex[i].originalLineNumber + 1];                
            }

            output.Add(
                String.Concat(
                    core[sortedIndex[i].startingAddress..lineEnding] + " ",
                    core[lineStarts[sortedIndex[i].originalLineNumber]..sortedIndex[i].startingAddress]));
        }

        return output.ToArray();
   }
}