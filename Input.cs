namespace Decomposing;
public class Input
{
    public Input()
    {
        Core = [];
        LineStarts = [];
    }
    public List<int> LineStarts;    
    public List<char[]> Core;
    public readonly char EndOfWord = '\u0003';
    public void StoreInCore(string[] lines, int chunk = 4)
    {
        if (lines is null) return;       

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;           

            LineStarts.Add(Core.Count);            
            
            foreach (char[] word in line.Replace(" ", EndOfWord + " ").Chunk(chunk))
            {                
                Core.Add(word);
            }
        }
    }
}