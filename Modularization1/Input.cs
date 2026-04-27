namespace Decomposing;
public class Input
{
    public Input()
    {
        Core = "";
        LineStarts = [];
    }
    public List<int> LineStarts;    
    public string Core;
    public readonly char EndOfWord = '\u0003';
    public void StoreInCore(string[] lines)
    {
        if (lines is null) return;       

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;           
            
            LineStarts.Add(Core.Length);            
            Core = string.Concat([Core, line.Replace(" ", EndOfWord + " ") + EndOfWord + " "]);
        }
    }
}
